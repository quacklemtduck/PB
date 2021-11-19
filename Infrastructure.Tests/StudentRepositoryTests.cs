namespace Infrastructure.Tests
{
    public class StudentRepositoryTests
    {
        private readonly PBContext _context;
        private readonly StudentRepositoryTests _repository;


        public StudentRepositoryTests()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<PBContext>();
            var context = new PBContext(builder.Options);
            context.Database.EnsureCreated();

            context.Students.AddRange(
                new Student("Markus") { Id = 1 },
                new Student("Line") { Id = 2 },
                new Student("Andreas") { Id = 3 },
                new Student("Daniel") { Id = 4 },
                new Student("Gustav") { Id = 5 },
                new Student("Jacob") { Id = 6 }
            );

            context.SaveChanges();

            _context = context;
            _repository = new StudentRepository(_context);
        }

        [Fact]
        public async Task ReadAsync_given_non_existing_ID_returns_isNone()
        {
            var option = await _repository.ReadAsync(-1);

            Assert.True(option.IsNone);
        }

        [Fact]
        public async Task ReadAsync_given_id_exists_returns_Student()
        {
            var option = await _repository.ReadAsync(2);
            var student = option.Value;

            Assert.Equal(2, student.Id);
        }

        [Fact]
        public async Task UpdateAsync_given_non_existing_id_returns_NotFound()
        {
            var student = new StudentUpdateDTO(-1, new List<int>());
            var status = await _repository.UpdateAsync(student.Id, student);

            Assert.Equal(null, status);
        }

        [Fact]
        public async Task CreateAsync_creates_new_student_with_generated_id()
        {
            var student = new StudentCreateDTO(5, "Markus");
            var created = await _repository.CreateAsync(student);

            Assert.Equal(5, created.Id);
            Assert.Equal("Markus5", created.Name);
        }

        [Fact]
        public async Task ReadAllAsync_returns_all_students()
        {
            var students = await _repository.ReadAsync();

            Assert.Collection(students,
                students => Assert.Equal(new StudentDetailsDTO(1, "student1", new List<int>()), students),
                students => Assert.Equal(new StudentDetailsDTO(2, "student2", new List<int>()), students),
                students => Assert.Equal(new StudentDetailsDTO(3, "student3", new List<int>()), students),
                students => Assert.Equal(new StudentDetailsDTO(4, "student4", new List<int>()), students),
                students => Assert.Equal(new StudentDetailsDTO(5, "student5", new List<int>()), students)
            );
        }
    }
}