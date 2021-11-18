namespace PBInfrastructure;

public class SupervisorRepository : ISupervisorRepository
{

    PBContext _context;

    public SupervisorRepository(PBContext context)
    {
        _context = context;
    }

    public Task<SupervisorDetailsDTO> CreateAsync(SuperVisorCreateDTO supervisor)
    {
        throw new NotImplementedException();
    }
    public Task<Option<SupervisorDetailsDTO>> ReadAsync(int supervisorId)
    {
        throw new NotImplementedException();
    }
    public Task<IReadOnlyCollection<SupervisorDetailsDTO>> ReadAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Status> UpdateAsync(int id, SupervisorUpdateDTO supervisor)
    {
        throw new NotImplementedException();
    }

}