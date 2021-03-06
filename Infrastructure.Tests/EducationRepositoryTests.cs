namespace PB.Infrastructure.Tests
{

    public class EducationRepositoryTests : IDisposable
    {

        private readonly ApplicationDbContext _context;
        private readonly EducationRepository _repository;

        public EducationRepositoryTests()
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
            var university = context.Universities.Find("ITU");


            context.SaveChanges();

            _context = context;
            _repository = new EducationRepository(_context);
        }

        [Fact]
        public async Task ReadAllByUniversityAsync_returns_all_educations()
        {
            var universityRepository = new UniversityRepository(_context);
            var university = _context.Universities.Find("ITU");
            var educations = await _repository.ReadAllByUniversityAsync(university.Id);

            Assert.Equal(9, educations.Count);



            var list = new List<string>();
            list.Add("Media Technology and Games");
            list.Add("Software Development and Technology");
            list.Add("Digital Innovation & Management");
            list.Add("Data Science");
            list.Add("Digital Design and Interactive Technologies");
            list.Add("Global Business Informatics");
            list.Add("Computer Science");
            list.Add("Software Development");

            foreach (var education in educations)
            {
                Assert.Contains(education.Name, list);
            }

        }

        [Fact]
        public async Task ReadByIDAsync_given_id_does_not_exist_returns_Null()
        {
            var education = await _repository.ReadByIDAsync(-1);

            Assert.Null(education);
        }



        [Theory]
        [InlineData(1, "Klinisk sygepleje (kandidat)", "Kandidat", "SDU")]
        [InlineData(2, "Veterin??rmedicin", "Bachelor", "KU")]
        public async Task ReadByIDAsync_given_id_exists_returns_Education(int id, string expectedName, string expectedDegree, string uniAbr)
        {
            var universityRepository = new UniversityRepository(_context);
            var university = _context.Universities.Find(uniAbr);

            var education = await _repository.ReadByIDAsync(id);

            var expected = new EducationDetailsDTO(id, expectedName, expectedDegree, university.Id);


            Assert.Equal(id, education?.Id);
            Assert.Equal(expectedName, education?.Name);
            Assert.Equal(expectedDegree, education?.Grade);
            Assert.Equal(university.Id, education?.UniversityId);
            Assert.Equal(university.Id, education?.UniversityId);
            Assert.Equal(expected, education);

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
}