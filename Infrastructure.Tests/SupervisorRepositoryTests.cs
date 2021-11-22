namespace Infrastructure.Tests{

public class SupervisorRepositoryTests : IDisposable
{
     private readonly PBContext _context;
    private readonly SupervisorRepository _repository;
    private bool disposedValue;

    /*public SupervisorRepositoryTests()
    {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            var builder = new DbContextOptionsBuilder<PBContext>();
            builder.UseSqlite(connection);
            var context = new PBContext(builder.Options);
            context.Database.EnsureCreated();

            context.Supervisors.AddRange(
                new Supervisor{Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com",Password = "***",ContactInfo = "info1", Projects = new List<Project>()},
                new Supervisor{Id = 2, Name = "Supervisor2", Email = "supervisor2@email.com",Password = "***",ContactInfo = "info2", Projects = new List<Project>()},
                new Supervisor{Id = 3, Name = "Supervisor3", Email = "supervisor3@email.com",Password = "***",ContactInfo = "info3", Projects = new List<Project>()},
                new Supervisor{Id = 4, Name = "Supervisor4", Email = "supervisor4@email.com",Password = "***",ContactInfo = "info4", Projects = new List<Project>()},
                new Supervisor{Id = 5, Name = "Supervisor5", Email = "supervisor5@email.com",Password = "***",ContactInfo = "info5", Projects = new List<Project>()}               
            );
            

            context.SaveChanges();

            _context = context;
            _repository = new SupervisorRepository(_context);
    }

    [Fact]
    public async Task CreateAsync_creates_new_supervisor_with_generated_id()
    {
        var supervisor = new SuperVisorCreateDTO("Supervisor6","supervisor6@email.com","***","info6");
        var created = await _repository.CreateAsync(supervisor);

        Assert.Equal(6, created.Id);
        Assert.Equal("Supervisor6", created.Name);
        Assert.Equal("supervisor6@email.com", created.Email);
        Assert.Equal("info6", created.ContactInfo);
        Assert.Empty(created.Projects);
    }

    [Fact]
    public async Task ReadAsync_given_id_exists_returns_Supervisor()
    {
        var supervisor = await _repository.ReadAsync(2);

        Assert.Equal(2, supervisor.Id);
        Assert.Equal("Supervisor2", supervisor.Name);
        Assert.Equal("supervisor2@email.com", supervisor.Email);
        Assert.Equal("info2", supervisor.ContactInfo);
        Assert.Empty(supervisor.Projects);
    }

    [Fact]
    public async Task ReadAsync_given_non_existing_id_returns_None()
    {
        var option = await _repository.ReadAsync(-1);

        Assert.Null(option);
    }

    [Fact]
    public async Task ReadAllAsync_returns_all_supervisors()
    {
        var supervisors = await _repository.ReadAllAsync();

        Assert.Collection(supervisors,
            supervisors => Assert.Equal(new SupervisorDetailsDTO(1,"supervisor1","supervisor1@email.com","info1",new List<int>()),supervisors),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(1,"supervisor2","supervisor2@email.com","info2",new List<int>()),supervisors),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(1,"supervisor3","supervisor3@email.com","info3",new List<int>()),supervisors),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(1,"supervisor4","supervisor4@email.com","info4",new List<int>()),supervisors),
            supervisors => Assert.Equal(new SupervisorDetailsDTO(1,"supervisor5","supervisor5@email.com","info5",new List<int>()),supervisors)
        );
    }

    [Fact]
    public async Task UpdateAsync_given_non_existing_id_returns_NotFound()
    {
        var supervisor = new SupervisorUpdateDTO(-1,new List<int>());
        var status = await _repository.UpdateAsync(supervisor.Id,supervisor);

        Assert.Equal(NotFound,status);
    }

    [Fact]
    public async Task UpdateAsync_given_existing_id_updates_supervisor_adding_projects()
    {
        var supervisor = new SupervisorUpdateDTO(1,new List<int>(){1,2,3}); 
        var status = await _repository.UpdateAsync(supervisor.Id,supervisor);
        Assert.Equal(Updated,status);

        var updatedSupervisor = await _repository.ReadAsync(1);
        Assert.Collection(updatedSupervisor.Projects,
            projects => Assert.Equal(1,projects),
            projects => Assert.Equal(2,projects),
            projects => Assert.Equal(3,projects)
        );
    }
*/
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