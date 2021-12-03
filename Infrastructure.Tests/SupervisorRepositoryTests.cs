using Core;
using Duende.IdentityServer.EntityFramework.Options;

namespace Infrastructure.Tests{

public class SupervisorRepositoryTests : IDisposable
{
    
    private readonly ApplicationDbContext _context;
    private readonly SupervisorRepository _repository;
    private bool disposedValue;

    public SupervisorRepositoryTests()
    {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlite(connection);
            var options = new Option<OperationalStoreOptions>(new OperationalStoreOptions());
            var context = new ApplicationDbContext(builder.Options, options);
            context.Database.EnsureCreated();

            context.Supervisors.AddRange(
                new Supervisor{Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>()},
                new Supervisor{Id = 2, Name = "Supervisor2", Email = "supervisor2@email.com", Projects = new List<Project>()},
                new Supervisor{Id = 3, Name = "Supervisor3", Email = "supervisor3@email.com", Projects = new List<Project>()},
                new Supervisor{Id = 4, Name = "Supervisor4", Email = "supervisor4@email.com", Projects = new List<Project>()},
                new Supervisor{Id = 5, Name = "Supervisor5", Email = "supervisor5@email.com", Projects = new List<Project>()}               
            );
            

            context.SaveChanges();

            _context = context;
            _repository = new SupervisorRepository(_context);
    }

    [Fact]
    public async Task CreateAsync_creates_new_supervisor_with_generated_id()
    {
        var supervisor = new SuperVisorCreateDTO("Supervisor6","supervisor6@email.com");
        var created = await _repository.CreateAsync(supervisor);

        Assert.Equal(6, created.Id);
        Assert.Equal("Supervisor6", created.Name);
        Assert.Equal("supervisor6@email.com", created.Email);
        Assert.Empty(created.Projects);
    }

    [Fact]
    public async Task ReadAsync_given_id_exists_returns_Supervisor()
    {
        var option = await _repository.ReadAsync(2);

        Assert.True(option.IsSome);
        var supervisor = option.Value;
        Assert.Equal(2, supervisor.Id);
        Assert.Equal("Supervisor2", supervisor.Name);
        Assert.Equal("supervisor2@email.com", supervisor.Email);
        Assert.Empty(supervisor.Projects);
    }

    [Fact]
    public async Task ReadAsync_given_non_existing_id_returns_None()
    {
        var option = await _repository.ReadAsync(-1);
        Assert.True(option.IsNone);
    }

    [Fact]
    public async Task ReadAllAsync_returns_all_supervisors()
    {
        var supervisors = await _repository.ReadAllAsync();

        Assert.Collection(supervisors,
            supervisors => Assert.Equal(new SupervisorDetailsDTO(1,"Supervisor1","supervisor1@email.com",new List<int>()).ToString(),supervisors.ToString()),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(2,"Supervisor2","supervisor2@email.com",new List<int>()).ToString(),supervisors.ToString()),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(3,"Supervisor3","supervisor3@email.com",new List<int>()).ToString(),supervisors.ToString()),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(4,"Supervisor4","supervisor4@email.com",new List<int>()).ToString(),supervisors.ToString()),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(5,"Supervisor5","supervisor5@email.com",new List<int>()).ToString(),supervisors.ToString())
        );
    }

    [Fact]
    public async Task UpdateAsync_given_non_existing_id_returns_NotFound()
    {
        var supervisor = new SupervisorUpdateDTO(-1,"supervisor-1");
        var status = await _repository.UpdateAsync(supervisor.Id,supervisor);

        Assert.Equal(NotFound,status);
    }

    [Fact]
    public async Task UpdateAsync_given_existing_id_updates_supervisor()
    {
        var supervisor = new SupervisorUpdateDTO(1,"supervisor1.1"); 
        var response = await _repository.UpdateAsync(supervisor.Id,supervisor);
        Assert.Equal(Updated,response);

        var updatedSupervisor = (await _repository.ReadAsync(1)).Value;
        Assert.Equal("supervisor1.1",updatedSupervisor.Name);
    }
    [Fact]
    public async Task DeleteAsync_given_non_existing_id_reeturns_NotFound()
    {
        var respone = await _repository.DeleteAsync(-1);
        Assert.Equal(NotFound,respone);
    }

    [Fact]
    public async Task DeleteAsync_given_existing_id_removes_supervisor()
    {
        var supervisor = (await _repository.ReadAsync(2)).Value;

        Assert.Equal(2, supervisor.Id);
        Assert.Equal("Supervisor2", supervisor.Name);
        Assert.Equal("supervisor2@email.com", supervisor.Email);
        Assert.Empty(supervisor.Projects);

        var respone = await _repository.DeleteAsync(2);
        Assert.Equal(Deleted,respone);
        var checkIfDeleted = await _repository.DeleteAsync(2);
        Assert.Equal(NotFound,checkIfDeleted);
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
    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            disposedValue = true;
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