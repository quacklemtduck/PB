namespace Infrastructure.Tests;

public class ProjectRepositoryTests : IDisposable
{
    private readonly PBContext _context;
    private readonly ProjectRepository _repository;

    public ProjectRepositoryTests()
    {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<PBContext>();
            builder.UseSqlite(connection);
            var context = new PBContext(builder.Options);
            context.Database.EnsureCreated();

            context.Projects.AddRange(
                new Project { ID = 1, Title = "Project1", Description = "This is project 1", SupervisorID = 1, Email = "supervisor1@mail.com", Deadline = DateTime.Parse("Okt 1, 2021"), getNotification = false, numberOfStudents = 1, CollabStudents = new List<Student>(), Tags = new List<Tag>(), Applications = new List<Application>(), Universities = new List<University>() },
                new Project { ID = 2, Title = "Project2", Description = "This is project 2", SupervisorID = 2, Email = "supervisor2@mail.com", Deadline = DateTime.Parse("Okt 2, 2021"), getNotification = true, numberOfStudents = 2, CollabStudents = new List<Student>(), Tags = new List<Tag>(), Applications = new List<Application>(), Universities = new List<University>() },
                new Project { ID = 3, Title = "Project3", Description = "This is project 3", SupervisorID = 3, Email = "supervisor3@mail.com", Deadline = DateTime.Parse("Okt 3, 2021"), getNotification = false, numberOfStudents = 3, CollabStudents = new List<Student>(), Tags = new List<Tag>(), Applications = new List<Application>(), Universities = new List<University>() },
                new Project { ID = 4, Title = "Project4", Description = "This is project 4", SupervisorID = 4, Email = "supervisor4@mail.com", Deadline = DateTime.Parse("Okt 4, 2021"), getNotification = true, numberOfStudents = 1, CollabStudents = new List<Student>(), Tags = new List<Tag>(), Applications = new List<Application>(), Universities = new List<University>() },
                new Project { ID = 5, Title = "Project5", Description = "This is project 5", SupervisorID = 5, Email = "supervisor5@mail.com", Deadline = DateTime.Parse("Okt 5, 2021"), getNotification = false, numberOfStudents = 2, CollabStudents = new List<Student>(), Tags = new List<Tag>(), Applications = new List<Application>(), Universities = new List<University>() }
            );

            context.SaveChanges();

            _context = context;
            _repository = new ProjectRepository(_context);
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
                where p.ID == projectID
                select p).SingleOrDefault();
            
            Assert.Equal((Response.Deleted), response);
            Assert.Null(foundProject);
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
    public void ListAll_()
    {
        //TODO: implement
    }

        [Fact]
        public async Task UpdateAsync_given_non_existing_Project_returns_NotFound()
        {
            var project = new ProjectUpdateDTO { 
                ID = 42,
                Title = "Project5",
                Description = "This is project 5",
                SupervisorID = 5,
                Email = "supervisor5@mail.com",
                Deadline = "",
                getNotification = false,
                numberOfStudents = 2,
                CollabStudents = new HashSet<string>(),
                Tags = new HashSet<string>(),
                Applications = new HashSet<string>(),
                Universities = new HashSet<string>() };

            var response = await _repository.UpdateAsync(42, project);

            Assert.Equal(NotFound, response);
        }

    [Fact]
        public async Task UpdateAsync_updates_existing_Project()
        {
            var project = new ProjectUpdateDTO { 
                ID = 5,
                Title = "newProject5",
                Description = "This is project 5, version 2",
                SupervisorID = 5,
                Email = "supervisor5@mail.com",
                Deadline = "",
                getNotification = false,
                numberOfStudents = 2,
                CollabStudents = new HashSet<string>(),
                Tags = new HashSet<string>(),
                Applications = new HashSet<string>(),
                Universities = new HashSet<string>() };

            var response = await _repository.UpdateAsync(5, project);

            Assert.Equal(Updated, response);
            var option = await _repository.ReadByIDAsync(1);
            var projectUpdated = option.Value;

            Assert.Empty(projectUpdated.CollabStudents);
            Assert.Empty(projectUpdated.Tags);
            Assert.Empty(projectUpdated.Applications);
            Assert.Empty(projectUpdated.Universities);
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
        var option = await _repository.ReadByIDAsync(1);

        var project = option.Value;

        Assert.Equal(1, project.ID);
        Assert.Equal(1, project.numberOfStudents);
        Assert.Equal(1, project.SupervisorID);
        Assert.Empty(project.CollabStudents);
        Assert.Equal(DateTime.Parse("Okt 1, 2021").ToString(), project.Deadline);
        Assert.Equal("This is project 1", project.Description);
        Assert.Equal("supervisor1@mail.com", project.Email);
        Assert.False(project.getNotification);
        Assert.Empty(project.Tags);
        Assert.Empty(project.Universities);
        Assert.Empty(project.CollabStudents);
        
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

}