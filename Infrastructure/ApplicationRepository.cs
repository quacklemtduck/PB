namespace PB.Infrastructure
{
    public class ApplicationRepository : IApplicationRepository
    {

        ApplicationDbContext _context;

        public ApplicationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<ApplicationDetailsDTO> CreateAsync(ApplicationCreateDTO application)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationDetailsDTO> ReadAsync(int applicationId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<ApplicationDetailsDTO>> ReadAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response> UpdateAsync(int id, ApplicationUpdateDTO appliation)
        {
            throw new NotImplementedException();
        }
    }
}
