namespace PB.Infrastructure
{
    public class UniversityRepository : IUniversityRepository
    {
        ApplicationDbContext _context;

        public UniversityRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IReadOnlyCollection<UniversityDetailsDTO>> ReadAllAsync()
        {
            return await _context.Universities
                .Select(u => new UniversityDetailsDTO(u.Id, u.Name, u.GetEducationIDs()))
                .ToListAsync();
        }

        public async Task<UniversityDetailsDTO?> ReadByIDAsync(string universityId)
        {
            var u = await _context.Universities.FindAsync(universityId);
            return u == null ? null : new UniversityDetailsDTO(Id: u.Id, Name: u.Name, u.GetEducationIDs());
        }

        public UniversityDetailsDTO? ReadByID(string universityId)
        {
            var u = _context.Universities.Find(universityId);
            return u == null ? null : new UniversityDetailsDTO(Id: u.Id, Name: u.Name, u.GetEducationIDs());
        }
    }
}
