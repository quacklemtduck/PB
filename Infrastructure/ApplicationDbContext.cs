using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Extensions.Options;
using Duende.IdentityServer.EntityFramework.Options;
using PB.Infrastructure.Authentication;

namespace PB.Infrastructure;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>, IPBContext
{
    public ApplicationDbContext(
        DbContextOptions options,
        IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
    { }

    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Supervisor> Supervisors => Set<Supervisor>();
    public DbSet<Application> Applications => Set<Application>();
    public DbSet<University> Universities => Set<University>();
    public DbSet<Education> Educations => Set<Education>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

}