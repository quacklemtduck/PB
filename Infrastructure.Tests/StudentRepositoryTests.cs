
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


            var universityRepository = new UniversityRepository(context);
            context.Students.AddRange(
                new Student{Id = 1,Name = "student1", Email = "student1@gmail.com", University = context.Universities.Find("KU")},
                new Student{Id = 2,Name = "student2", Email = "student2@gmail.com", University = context.Universities.Find("KU")},
                new Student{Id = 3,Name = "student3", Email = "student3@gmail.com", University = context.Universities.Find("KU")},
                new Student{Id = 4,Name = "student4", Email = "student4@gmail.com", University = context.Universities.Find("KU")},
                new Student{Id = 5,Name = "student5", Email = "student5@gmail.com", University = context.Universities.Find("KU")},
                new Student{Id = 6,Name = "student6", Email = "student6@gmail.com", University = context.Universities.Find("KU")}
            );

            context.SaveChanges();

            _context = context;
            _repository = new StudentRepository(_context);
        }

        [Fact]
        public async Task ReadAsync_given_id_exists_returns_Student()
        {
            
            var option = await _repository.ReadAsync(2);
            var student = option.Value;

            Assert.Equal(2, student.Id);
            Assert.Equal("student2", student.Name);
            Assert.Equal("student2@gmail.com", student.Email);
            Assert.Equal("Københavns Universitet", student.University);
        }

        [Fact]
        public async Task UpdateAsync_given_non_existing_id_returns_NotFound()
        {
            var student = new StudentUpdateDTO{
                Id = 10,
                Name = "Lars",
                Projects = new List<string>(),
                Applications = new HashSet<string>()
                };

                
            var response = await _repository.UpdateAsync(student.Id, student);

            Assert.Equal(NotFound, response);
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
            
            var student = new StudentCreateDTO{ Name = studentName, Email=studentEmail, University = university?.Name};
            var created = await _repository.CreateAsync(student);

            Assert.Equal(7, created.Id);
            Assert.Equal(studentName, created.Name);
            
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

        private string getDeadlineString(){
            DateTime deadline = DateTime.Parse("Dec 22, 2021");
            return ProjectRepository.convertDateTimeToString(deadline);
        }
    }
    
}