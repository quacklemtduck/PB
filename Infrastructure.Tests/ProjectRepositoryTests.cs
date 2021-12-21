namespace PB.Infrastructure.Tests
{

    public class ProjectRepositoryTests : IDisposable
    {
        
        private readonly ApplicationDbContext _context;
        private readonly ProjectRepository _repository;

        public ProjectRepositoryTests()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite(connection);
            var options = new Option<OperationalStoreOptions>(new OperationalStoreOptions());
            var context = new ApplicationDbContext(builder.Options, options);
            context.Database.EnsureCreated();

            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };
            //context.Supervisors.Add(supervisor);
            var universityRepository = new UniversityRepository(context);
            var university = context.Universities.Find("KU");


            var student = new Student { Name = "Test", Email = "Test@gmail.com", University = university };
            context.Students.Add(student);

            DateTime deadline = DateTime.Parse("Dec 22, 2021");

            var project = new Project { Id = 5, Title = "Project5", Description = "This is project 5", Supervisor = supervisor};


            context.Projects.AddRange(
                new Project { Id = 1, Title = "Project1", Description = "This is project 1", Supervisor = supervisor },
                new Project { Id = 2, Title = "Project2", Description = "This is project 2", Supervisor = supervisor },
                new Project { Id = 3, Title = "Project3", Description = "This is project 3", Supervisor = supervisor },
                new Project { Id = 4, Title = "Project4", Description = "This is project 4", Supervisor = supervisor },
                project
            );
            
            var application = new Application { Title = "Softwareudvikler søger nye udfordringer", Student = student, Project = project };
            context.Applications.Add(application);

            context.SaveChanges();

            _context = context;
            _repository = new ProjectRepository(_context);
        }

        
        [Theory]
        [InlineData("Project 6", "This is project 6", "1", false, Status.Hidden, 0)]
        [InlineData(null, "This is a closed project", "1", true, Status.Closed, 1)]
        [InlineData("Visible project", "This is a visible project", null, true, Status.Visible, 3)]
        public async Task CreateAsync_equivalence(string projectTitle, string projectDescription, string supervisorID,bool notification, Status status, int numberOfEducations)
        {
            SupervisorRepository supervisorRepository = new SupervisorRepository(_context);

            var educations = new HashSet<int>();
            for (int i = 1; i < numberOfEducations + 1; i++)
            {
                educations.Add(i);
            }

            var project = new ProjectCreateDTO
            {
                Title = projectTitle,
                Description = projectDescription,
                Supervisor = supervisorID,
                Notification = notification,
                Status = status,
                Educations = educations
            };
            try
            {
                var created = await _repository.CreateAsync(project);
                var projectID = 6;
                Assert.Equal(projectID, created.ID);
                Assert.Equal(projectTitle, created.Title);
                Assert.Equal(projectDescription, created.Description);
                Assert.Equal(_context.Supervisors.Find(supervisorID)?.Name, created.Supervisor);
                Assert.Equal(notification, created.Notification);
                Assert.Equal(status, created.Status);
                //Assert.Equal(numberOfEducations, created.Educations.Count);

                for (int i = 1; i < numberOfEducations + 1; i++)
                {
                    Assert.Contains(i, educations);
                }
            }
            catch (System.Exception e)
            {
                Assert.Equal("Microsoft.EntityFrameworkCore.Relational",e.Source);
                Assert.True(projectTitle == null || supervisorID == null);
            }

        }

        [Theory]
        [InlineData(-100, Response.NotFound)]
        [InlineData(0, Response.NotFound)]
        [InlineData(1, Response.Deleted)]
        [InlineData(3, Response.Deleted)]
        [InlineData(5, Response.Deleted)]
        [InlineData(6, Response.NotFound)]
        [InlineData(100, Response.NotFound)]
        public async Task Delete_boundary(int projectID, Response expectedOutput)
        {

            var response = await _repository.DeleteAsync(projectID);
            _context.SaveChanges();

            Project? foundProject =
                (from p in _context.Projects
                 where p.Id == projectID
                 select p).SingleOrDefault();

            Assert.Equal(expectedOutput,response);
            Assert.Null(foundProject);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public async Task Delete_returns_null(int projectID)
        {
            var response = await _repository.DeleteAsync(projectID);
            _context.SaveChanges();

            Project? foundProject =
                (from p in _context.Projects
                 where p.Id == projectID
                 select p).SingleOrDefault();

            Assert.Equal((Response.Deleted), response);
            Assert.Null(foundProject);
        }

        [Theory]
        [InlineData(-100, false)]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(100, false)]
        public async Task ReadByIDAsync_Equivalence(int projectID, bool expectedOutput)
        {
            var option = await _repository.ReadByIDAsync(projectID);
            Assert.Equal(expectedOutput,option.IsSome);

            if (expectedOutput){
                var project = option.Value;
                Assert.Equal(projectID,project.ID);
            }
        }

        [Theory]
        [InlineData(-100, Status.Closed, Response.NotFound)]
        [InlineData(0, Status.Hidden, Response.NotFound)]
        [InlineData(1, Status.Closed, Response.Updated)]
        [InlineData(3, Status.Hidden, Response.Updated)]
        [InlineData(5, Status.Visible, Response.Updated)]
        [InlineData(6, Status.Hidden, Response.NotFound)]
        [InlineData(100,Status.Visible, Response.NotFound)]
        public async Task UpdateStatus_Equivalance(int projectID, Status status, Response expectedResponse)
        {
            var visibilityUpdate = new ProjectVisibilityUpdateDTO(projectID,status);
            var response = await _repository.UpdateStatusAsync(visibilityUpdate);
            Assert.Equal(expectedResponse,response);

            if(expectedResponse == Response.Updated) {
                var updatedProject = await _repository.ReadByIDAsync(projectID);
                Assert.Equal(status,updatedProject.Value.Status);
            }
        }

        [Theory]
        [InlineData("Project 6", "This is project 6", false, Status.Hidden, 0,Response.NotFound)]
        [InlineData(null, "This is a closed project", true, Status.Closed, 1,Response.Updated)]
        [InlineData("Visible project", "This is a visible project", true, Status.Visible, 3,Response.Updated)]
        [InlineData("ver Visible project", null, true, Status.Visible, 4,Response.Updated)]
        [InlineData("Visible project2", "This is a visible project2", true, Status.Visible, 5, Response.Updated)]
        [InlineData("Visible project3", "This is a visible project3", true, Status.Visible, 6, Response.NotFound)]
        public async Task UpdateAsync_Equivalence(string projectTitle, string projectDescription,bool notification, Status status, int projectID, Response expectedResponse)
        {
            var project = new ProjectUpdateDTO
            {
                Id = projectID,
                Title = projectTitle,
                Description = projectDescription,
                Notification = notification
            };
            
            try
            {
                var response = await _repository.UpdateAsync(project);
                Assert.Equal(expectedResponse,response);
                if (expectedResponse == Response.Updated)
                {
                    var projectUpdated = (await _repository.ReadByIDAsync(projectID)).Value;
                    Assert.Equal(projectTitle, projectUpdated.Title);
                    Assert.Equal(projectDescription,projectUpdated.Description);
                    Assert.Empty(projectUpdated.Educations);
                }
                
            }
            catch (System.Exception e)
            {
                Assert.Equal("Microsoft.EntityFrameworkCore.Relational",e.Source);
                Assert.Null(projectTitle);
            }

        }
        [Fact]
        public async Task DeleteAsync_given_non_existing_ID_returns_NotFound()
        {
            var response = await _repository.DeleteAsync(420);

            Assert.Equal((Response.NotFound), response);
        }

        [Fact]
        public async Task DeleteAsync_deletes_and_returns_Deleted()
        {
            var response = await _repository.DeleteAsync(2);

            var entity = await _context.Projects.FindAsync(2);

            Assert.Equal(Response.Deleted, response);
            Assert.Null(entity);
        }

        [Fact]
        public async Task ListAllAsync_returns_all_projects()
        {
            var projects = await _repository.ListAllAsync();


            Assert.Collection(projects,
                projects => Assert.Equal(new ProjectListDTO(1, "Project1", "This is project 1", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(2, "Project2", "This is project 2", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(3, "Project3", "This is project 3", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(4, "Project4", "This is project 4", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(5, "Project5", "This is project 5", Status.Visible), projects)
            );
        }

        [Fact]
        public async Task ListAllAsync_returns_all_supervisors_projects()
        {
            var projects = await _repository.ListAllAsync("1");


            Assert.Collection(projects,
                projects => Assert.Equal(new ProjectListDTO(1, "Project1", "This is project 1", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(2, "Project2", "This is project 2", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(3, "Project3", "This is project 3", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(4, "Project4", "This is project 4", Status.Visible), projects),
                projects => Assert.Equal(new ProjectListDTO(5, "Project5", "This is project 5", Status.Visible), projects)
            );
        }

        [Fact]
        public async Task UpdateAsync_given_non_existing_Project_returns_NotFound()
        {
            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };

            var project = new ProjectUpdateDTO
            {
                Id = 42,
                Title = "Project5",
                Description = "This is project 5",
                Supervisor = supervisor.ToString(),
                Notification = false,
                ChosenStudents = new HashSet<string>(),
                Applications = new HashSet<string>(),
                Educations = new HashSet<int>()
            };

            var response = await _repository.UpdateAsync(project);

            Assert.Equal(NotFound, response);
        }

        [Fact]
        public async Task UpdateAsync_updates_existing_Project()
        {
            //var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };


            var project = new ProjectUpdateDTO
            {
                Id = 5,
                Title = "newProject5",
                Description = "This is project 5, version 2",
                Notification = false,
                ChosenStudents = new HashSet<string>(),
                Applications = new HashSet<string>(),
                Educations = new HashSet<int>()
            };

            var response = await _repository.UpdateAsync(project);

            Assert.Equal(Updated, response);
            var projectUpdated = (await _repository.ReadByIDAsync(5)).Value;
            Assert.Equal("newProject5", projectUpdated.Title);
            //Assert.Empty(projectUpdated.ChosenStudents);
            //Assert.Empty(projectUpdated.Applications);
            Assert.Empty(projectUpdated.Educations);
        }

        [Fact]
        public async Task UpdateAsync_adds_students_existing_Project()
        {
            var student = new Student { Name = "Test" };
            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };
            var ChosenStudents = new HashSet<string>();
            ChosenStudents.Add(student.Name);

            var project = new ProjectUpdateDTO
            {
                Id = 5,
                Title = "newProject5",
                Description = "This is project 5, version 2",
                Supervisor = "Supervisor1",
                Notification = false,
                //ChosenStudents = new HashSet<string>() { student.Name },
                ChosenStudents = ChosenStudents,
                Applications = new HashSet<string>(),
                Educations = new HashSet<int>()
            };

            var response = await _repository.UpdateAsync(project);

            Assert.Equal(Updated, response);
            var projectUpdated = (await _repository.ReadByIDAsync(5)).Value;
            
            Assert.Equal("newProject5" , projectUpdated.Title);
            //Assert.Equal(1 , projectUpdated.ChosenStudents.Count);
            //Assert.True(projectUpdated.ChosenStudents.Contains(student.Name));
            //Assert.Empty(projectUpdated.Applications);
            Assert.Empty(projectUpdated.Educations);
        }

        [Fact]
        public async Task UpdateAsync_adds_application_existing_Project()
        {
            var application = new Application { Title = "Softwareudvikler søger nye udfordringer" };

            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };
        
            var applications = new HashSet<string>();
            applications.Add(application.Title);

            var project = new ProjectUpdateDTO
            {
                Id = 5,
                Title = "newProject5",
                Description = "This is project 5, version 2",
                Supervisor = "Supervisor1",
                Notification = false,
                ChosenStudents = new HashSet<string>(),
                Applications = applications,
                Educations = new HashSet<int>()
            };

            var response = await _repository.UpdateAsync(project);

            Assert.Equal(Updated, response);
            var projectUpdated = (await _repository.ReadByIDAsync(5)).Value;

            Assert.Equal("newProject5", projectUpdated.Title);

            Assert.Equal(1, projectUpdated.Applications.Count());
            Assert.True(projectUpdated.Applications.Contains(application.Title));
            

            Assert.Empty(projectUpdated.ChosenStudents);
            Assert.Empty(projectUpdated.Educations);
        }

        [Fact]
        public async Task ReadByIDAsync_given_id_does_not_exist_returns_None()
        {
            var option = await _repository.ReadByIDAsync(42);

            Assert.True(option.IsNone);
        }

        [Fact]
        public async Task ReadByIDAsync_given_id_exists_returns_Project()
        {
            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com",Projects = new List<Project>() };

            var project = (await _repository.ReadByIDAsync(1)).Value;

            Assert.Equal(supervisor.Id, project.Supervisor);
            Assert.Equal(1, project.ID);
            Assert.Empty(project.ChosenStudents);
            Assert.Equal("This is project 1", project.Description);
            Assert.False(project.Notification);
            Assert.Empty(project.Educations);
            Assert.Empty(project.ChosenStudents);

        }


        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        private string getDeadlineString(){
            DateTime deadline = DateTime.Parse("Dec 22, 2021");
            return ProjectRepository.convertDateTimeToString(deadline);
        }
    }
}