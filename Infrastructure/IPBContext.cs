namespace PBInfrastructure;

public interface IPBContext : IDisposable{
    DbSet<Project> Projects {get;}
    DbSet<Student> Students {get;}
    DbSet<Supervisor> Supervisors {get;}
    DbSet<Application> Applications {get;}
}