namespace PB.Infrastructure
{

    public class SupervisorRepository : ISupervisorRepository
    {

        PBContext _context;

        public SupervisorRepository(PBContext context)
        {
            _context = context;
        }

        public async Task<SupervisorDetailsDTO> CreateAsync(SuperVisorCreateDTO supervisor)
        {
            var sup = new Supervisor{
                Name = supervisor.Name,
                Email = supervisor.Email,
                Password = supervisor.Password,
                ContactInfo = supervisor.ContactInfo,
                Projects = new List<Project>()
            };

            _context.Supervisors.Add(sup);
            
            await _context.SaveChangesAsync();

            return new SupervisorDetailsDTO(sup.Id,sup.Name,sup.Email,sup.ContactInfo,new List<int>());
        }
        public async Task<IReadOnlyCollection<SupervisorDetailsDTO>> ReadAllAsync()
        {
            return await _context.Supervisors
                .Select(s => new SupervisorDetailsDTO(s.Id,s.Name,s.Email,s.ContactInfo,s.Projects.Select(p => p.Id).ToList<int>()))
                .ToListAsync();
        }

        public async Task<SupervisorDetailsDTO> ReadAsync(int supervisorId)
        {
            var supervisor = await _context.Supervisors.FirstOrDefaultAsync(s => s.Id == supervisorId);
            return supervisor == null ? null : new SupervisorDetailsDTO(supervisor.Id,supervisor.Name,supervisor.Email,supervisor.ContactInfo,supervisor.Projects.Select(p => p.Id).ToList<int>());
        }

        public async Task<Response> UpdateAsync(int id, SupervisorUpdateDTO supervisor)
        {
            var entity = _context.Supervisors.FirstOrDefault(s => s.Id == id);
            if (entity == null) return NotFound;
            
            entity.Name = supervisor.Name;
            entity.ContactInfo = supervisor.ContactInfo;
            await _context.SaveChangesAsync();
            return Updated;
        }

        public async Task<Response> DeleteAsync(int id)
        {
            var entity = _context.Supervisors.FirstOrDefault(s => s.Id == id);
            if (entity == null) return NotFound;

            _context.Supervisors.Remove(entity);
            await _context.SaveChangesAsync();
            return Deleted;
        }

    }
}