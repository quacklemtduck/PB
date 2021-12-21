namespace PB.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UniversityController : ControllerBase
    {
        private readonly IEducationRepository _EducationRepository;
        private readonly IUniversityRepository _UniversityRepository;

        public UniversityController(IEducationRepository eduRepo, IUniversityRepository uniRepo)
        {
            _EducationRepository = eduRepo;
            _UniversityRepository = uniRepo;
        }

        [HttpGet]
        public async Task<IReadOnlyCollection<EducationDetailsDTO>> GetAllEducations()
        {
            return await _EducationRepository.ReadAllAsync();
        }
    }

}