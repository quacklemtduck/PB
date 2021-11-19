using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PB.Infrastructure
{

    public class PBContext : DbContext, IPBContext
    {
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Supervisor> Supervisors => Set<Supervisor>();
        public DbSet<Application> Applications => Set<Application>();
        public PBContext(DbContextOptions<PBContext> options) : base(options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder options){
        //     // IConfigurationRoot configuration = new ConfigurationBuilder()
        //     // .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //     // .AddJsonFile("appsettings.json")
        //     // .Build();
        //     options.UseSqlite("Data Source=PB.db");
        // }
    }
}