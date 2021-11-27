namespace PB.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentRepository _repository;

        public StudentsController(ILogger<StudentsController> logger, IStudentRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
         public async Task<IReadOnlyCollection<StudentDetailsDTO>> Get()
             => await _repository.ReadAllAsync();

         [ProducesResponseType(404)]
         [ProducesResponseType(typeof(StudentDetailsDTO), 200)]
         [HttpGet("{id}")]
         public async Task<ActionResult<StudentDetailsDTO>> Get(int id)
             => (await _repository.ReadAsync(id)).ToActionResult();

         [HttpPost]
         [ProducesResponseType(typeof(StudentDetailsDTO), 201)]
         public async Task<IActionResult> Post(StudentCreateDTO student)
         {
             var created = await _repository.CreateAsync(student);

             return CreatedAtRoute(nameof(Get), new { created.Id }, created);
         }

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