namespace PB.Infrastructure
{
    public class EducationRepository : IEducationRepository
    {
        ApplicationDbContext _context;

        public EducationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<EducationDetailsDTO>> ReadAllAsync()
        {
            return await _context.Educations.Select(e => new EducationDetailsDTO(e.Id, e.Name, e.Grade, e.University.Id)).ToListAsync();
        }

        public async Task<IReadOnlyCollection<EducationDetailsDTO>> ReadAllByUniversityAsync(string universityId)
        {
            return await _context.Educations
                .Where(e => e.University.Id == universityId)
                .Select(e => new EducationDetailsDTO(e.Id, e.Name, e.Grade, e.University.Id))
                .ToListAsync();
        }

        public async Task<EducationDetailsDTO?> ReadByIDAsync(int educationId)
        {
            var e = await _context.Educations.FindAsync(educationId);
            return e == null ? null : new EducationDetailsDTO(e.Id, e.Name, e.Grade, e.University.Id);
        }

    }
}
