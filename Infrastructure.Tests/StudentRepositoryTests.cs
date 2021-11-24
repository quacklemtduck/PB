namespace Infrastructure.Tests
{
    public class StudentRepositoryTests
    {
        private readonly PBContext _context;
        private readonly StudentRepository _repository;


        public StudentRepositoryTests()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<PBContext>();
            builder.UseSqlite(connection);
            var context = new PBContext(builder.Options);
            context.Database.EnsureCreated();

            context.Students.AddRange(
                new Student{Id = 1,Name = "student1"},
                new Student{Id = 2,Name = "student2"},
                new Student{Id = 3,Name = "student3"},
                new Student{Id = 4,Name = "student4"},
                new Student{Id = 5,Name = "student5"},
                new Student{Id = 6,Name = "student6"}
            );

            context.SaveChanges();

            _context = context;
            _repository = new StudentRepository(_context);
        }

        [Fact]
        public async Task ReadAsync_given_id_exists_returns_Student()
        {
            var student = await _repository.ReadAsync(2);

            Assert.Equal(2, student.Id);
        }

        [Fact]
        public async Task UpdateAsync_given_non_existing_id_returns_NotFound()
        {
            var student = new StudentUpdateDTO(10, "Lars", new List<int>());
            var response = await _repository.UpdateAsync(student.Id, student);

            Assert.Equal(NotFound, response);
        }

        [Fact]
        public async Task CreateAsync_creates_new_student_with_generated_id()
        {
            var student = new StudentCreateDTO{Name = "Markus"};
            var created = await _repository.CreateAsync(student);

            Assert.Equal(7, created.Id);
            Assert.Equal("Markus", created.Name);
        }

        [Fact]
        public async Task ReadAllAsync_returns_all_students()
        {
            var students = await _repository.ReadAllAsync();

            Assert.Collection(students,
                students => Assert.Equal(new StudentDetailsDTO(1, "student1", new List<int>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(2, "student2", new List<int>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(3, "student3", new List<int>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(4, "student4", new List<int>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(5, "student5", new List<int>()).ToString(), students.ToString()),
                students => Assert.Equal(new StudentDetailsDTO(6, "student6", new List<int>()).ToString(), students.ToString())
            );
        }
    }
}