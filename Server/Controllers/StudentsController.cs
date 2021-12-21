namespace PB.Server.Controllers
{


    //[Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentRepository _repository;

        public StudentsController(ILogger<StudentsController> logger, IStudentRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //[Authorize] WE DON'T NEED THIS
        /*[HttpGet]
        public async Task<IReadOnlyCollection<StudentDetailsDTO>> Get()
             => await _repository.ReadAllAsync();*/

        //[Authorize]
        [ProducesResponseType(404)]
        [ProducesResponseType(typeof(StudentDetailsDTO), 200)]
        [HttpGet("{id}", Name = "GetStudent")]
        public async Task<ActionResult<StudentDetailsDTO>> GetStudent(int id)
            => (await _repository.ReadAsync(id)).ToActionResult();

        [HttpPost]
        [ProducesResponseType(typeof(StudentDetailsDTO), 201)]
        public async Task<IActionResult> Post(StudentCreateDTO student)
        {
            var created = await _repository.CreateAsync(student);

            return CreatedAtRoute(nameof(GetStudent), new { created.Id }, created);
        }

        //[Authorize]
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromBody] StudentUpdateDTO student)
            => (await _repository.UpdateAsync(id, student)).ToActionResult();

        /*[HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
            => (await _repository.DeleteAsync(id)).ToActionResult();*/

    }
}