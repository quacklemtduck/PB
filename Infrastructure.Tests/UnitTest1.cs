using Xunit;

namespace Infrastructure.Tests
{

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite(connection);
            var options = new Option<OperationalStoreOptions>(new OperationalStoreOptions());
            var context = new ApplicationDbContext(builder.Options, options);
            context.Database.EnsureCreated();
            context.Seed();

            var uniRep = new UniversityRepository(context);
            var eduRep = new EducationRepository(context);

            Console.WriteLine("-----------------HERE--------------------");
            Console.WriteLine(uniRep.ReadByID("KU").Educations.Count());
            Console.WriteLine(uniRep.ReadByID("KU").Name);
            Console.WriteLine(context.Universities.Find("KU").Educations.Count());
            Console.WriteLine(context.Educations.Find(1).Name);
            Console.WriteLine(context.Educations.Find(1).University.Name);
        }
    }
}