
namespace Infrastructure.Tests
{
    public class StudentRepositoryTests : IDisposable
    {
        private readonly ApplicationDbContext _context;
        private readonly StudentRepository _repository;


        public StudentRepositoryTests()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite(connection);
            var options = new Option<OperationalStoreOptions>(new OperationalStoreOptions());
            var context = new ApplicationDbContext(builder.Options, options);
            context.Database.EnsureCreated();
            context.SeedEducations();


            var universityRepository = new UniversityRepository(context);
            context.Students.AddRange(
                new Student{Id = 1,Name = "student1", Email = "student1@gmail.com", Education = context.Educations.Find(1)},
                new Student{Id = 2,Name = "student2", Email = "student2@gmail.com", Education = context.Educations.Find(1)},
                new Student{Id = 3,Name = "student3", Email = "student3@gmail.com", Education = context.Educations.Find(1)},
                new Student{Id = 4,Name = "student4", Email = "student4@gmail.com", Education = context.Educations.Find(1)},
                new Student{Id = 5,Name = "student5", Email = "student5@gmail.com", Education = context.Educations.Find(1)},
                new Student{Id = 6,Name = "student6", Email = "student6@gmail.com", Education = context.Educations.Find(1)}
            );

            context.SaveChanges();

            _context = context;
            _repository = new StudentRepository(_context);
        }

        [Theory]
        [InlineData(1, "student1", "student1@gmail.com", "Syddansk Universitet")]
        [InlineData(2, "student2", "student2@gmail.com", "Syddansk Universitet")]
        [InlineData(3, "student3", "student3@gmail.com", "Syddansk Universitet")]
        [InlineData(4, "student4", "student4@gmail.com", "Syddansk Universitet")]
        [InlineData(5, "student5", "student5@gmail.com", "Syddansk Universitet")]
        [InlineData(6, "student6", "student6@gmail.com", "Syddansk Universitet")]
        public async Task ReadAsync_given_id_exists_returns_Student(int id, string name, string email, string? university)
        {
            var option = await _repository.ReadAsync(id);
            var student = option.Value;
            Assert.Equal(id, student.Id);
            Assert.Equal(name, student.Name);
            Assert.Equal(email, student.Email);
            Assert.Equal(university, student.University);
        }

        [Fact]
        public async Task UpdateAsync_given_non_existing_id_returns_NotFound()
        {
            var student = new StudentUpdateDTO
            {
                Id = 10,
                Name = "Lars"
            };


            var response = await _repository.UpdateAsync(student.Id, student);

            Assert.Equal(NotFound, response);
        }


        [Fact]
        public async Task UpdateAsync_updates_existing_Student()
        {

            var StudentUpdated = (await _repository.ReadAsync(1));

            Assert.True(StudentUpdated.IsSome);

            var studentUpdateDTO = new StudentUpdateDTO
            {
                Id = 1,
                Name = "Lars",
                Email = "Lars@gmail.com"
            };


            var response = await _repository.UpdateAsync(1, studentUpdateDTO);

            Assert.Equal(Updated, response);

            var student = _context.Students.Find(1);
            Assert.Equal("Lars", student.Name);
            Assert.Equal("Lars@gmail.com", student.Email);
            Assert.Empty(student.Applications);
        }

        [Theory]
        [InlineData(7, "KU", "Markus", "Markus@gmail.com")]
        [InlineData(7, "KU", "Gustav", "Gustav@gmail.com")]
        [InlineData(7, "KU", "Daniel", "Daniel@gmail.com")]
        [InlineData(7, "KU", "Jacob", "Jacob@gmail.com")]
        [InlineData(7, "KU", "Andreas", "Andreas@gmail.com")]
        [InlineData(7, "KU", "Line", "Line@gmail.com")]
        public async Task CreateAsync_creates_new_student(int id, string universityAbbreviation, string studentName, string studentEmail)
        {
            var universityRepository = new UniversityRepository(_context);
            var university = _context.Universities.Find(universityAbbreviation);
            var student = new StudentCreateDTO { Name = studentName, Email = studentEmail, EducationId = 1};
            var created = await _repository.CreateAsync(student);

            Assert.Equal(7, created.Id);
            Assert.Equal(studentName, created.Name);

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


        /*[Fact]
        public async Task ReadAllAsync_returns_all_students()
        {
            var students = await _repository.ReadAllAsync();
            var university = new University {Name = "Københavns Universitet", Abbreviation = "KU"};


            Assert.Collection(students,
                students => Assert.Equal(new StudentDetailsDTO(1, "student1", university.Name, "student1@gmail.com", new HashSet<string>(), new HashSet<string>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(2, "student2", university.Name, "student2@gmail.com", new HashSet<string>(), new HashSet<string>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(3, "student3", university.Name, "student3@gmail.com", new HashSet<string>(), new HashSet<string>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(4, "student4", university.Name, "student4@gmail.com", new HashSet<string>(), new HashSet<string>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(5, "student5", university.Name, "student5@gmail.com", new HashSet<string>(), new HashSet<string>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(6, "student6", university.Name, "student6@gmail.com", new HashSet<string>(), new HashSet<string>()).ToString(), students.ToString())
            );
        }*/

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

        // private string getDeadlineString(){
        //     DateTime deadline = DateTime.Parse("Dec 22, 2021");
        //     return ProjectRepository.convertDateTimeToString(deadline);
        // }
    }

}