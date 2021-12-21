namespace PB.Infrastructure.Tests
{

    public class UniversityRepositoryTests : IDisposable
    {
        
        private readonly ApplicationDbContext _context;
        private readonly UniversityRepository _repository;

        public UniversityRepositoryTests()
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
            _repository = new UniversityRepository(_context);
        }

        [Fact]
        public async Task ReadAllAsync_returns_all_Universities()
        {
            var universities = await _repository.ReadAllAsync();
            Assert.Equal(4, universities.Count); //don't count uni abbrv

            bool[] checker = new bool[4];
            foreach (var univeristy in universities)
            {
                if (univeristy.Id == "CBS" && univeristy.Name == "Copenhagen Business School")
                {
                    checker[0] = true;
                }
                if (univeristy.Id == "ITU" && univeristy.Name == "IT-Universitet i København")
                {
                    checker[1] = true;
                }
                if (univeristy.Id == "KU" && univeristy.Name == "Københavns Universitet")
                {
                    checker[2] = true;
                }
                if (univeristy.Id == "SDU" && univeristy.Name == "Syddansk Universitet")
                {
                    checker[3] = true;
                }
            }

            var checkerExpected = new bool[]{true, true, true, true};

            Assert.Equal(checkerExpected, checker);
            
            // Assert.Contains(new UniversityDetailsDTO("CBS", "Copenhagen Business School", new HashSet<int>()), universities);
            // Assert.Contains(new UniversityDetailsDTO("ITU", "IT-Universitet i København", new HashSet<int>()), universities);
            // Assert.Contains(new UniversityDetailsDTO("KU", "Københavns Universitet", new HashSet<int>()), universities);
            // Assert.Contains(new UniversityDetailsDTO("SDU", "Syddansk Universitet", new HashSet<int>()), universities);


        }

        [Fact]
        public async Task ReadByIDAsync_given_id_does_not_exist_returns_Null()
        {
            var university = _repository.ReadByID("-1");

            Assert.Null(university);
        }



        [Theory] //see data in ModelBuilderExtensions.cs
        [InlineData("SDU", "Syddansk Universitet", 163)]
        [InlineData("KU", "Københavns Universitet", 178)]
        [InlineData("ITU", "IT-Universitet i København", 9)]
        [InlineData("CBS", "Copenhagen Business School", 55)]
        public async Task ReadByIDAsync_given_id_exists_returns_University(string id, string name, int educations)
        {
            
            var university = await _repository.ReadByIDAsync(id);
            Assert.NotNull(university);
            Assert.Equal(id, university?.Id);
            Assert.Equal(name, university?.Name);
            Assert.Equal(educations, university?.Educations?.Count);
        }

        [Fact]
        public async Task ReadByIDAsync_given_id_exists_returns_ITU()
        {
            var id = "ITU";
            var name = "IT-Universitet i København";
            var university = await _repository.ReadByIDAsync(id);
            
            Assert.Equal(id, university?.Id);
            Assert.Equal(name, university?.Name);

            Assert.Equal(9, university.Educations.Count);
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