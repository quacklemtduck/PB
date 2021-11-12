namespace PBInfrastructure;

public class PBContext : DbContext, IPBContext{
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Supervisor> Supervisors => Set<Supervisor>();
    public DbSet<Application> Applications => Set<Application>();
    public PBContext(DbContextOptions<PBContext> options) : base(options) { } 
}