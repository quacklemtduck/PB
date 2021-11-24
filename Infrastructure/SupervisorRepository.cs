namespace PB.Infrastructure
{

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
        public Task<IReadOnlyCollection<SupervisorDetailsDTO>> ReadAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SupervisorDetailsDTO> ReadAsync(int supervisorId)
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(int id, SupervisorUpdateDTO supervisor)
        {
            throw new NotImplementedException();
        }

    }
}