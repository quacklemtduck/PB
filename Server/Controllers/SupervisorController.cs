namespace PB.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]/[action]")]
public class SupervisorController : ControllerBase
{
    private readonly ILogger<SupervisorController> _logger;
    private readonly ISupervisorRepository _repository;

    public SupervisorController(ILogger<SupervisorController> logger, ISupervisorRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [AllowAnonymous]
    [ProducesResponseType(404)]
    [ProducesResponseType(typeof(SupervisorDetailsDTO), 200)]
    [HttpGet("{id}", Name = "GetSupervisor")]
    public async Task<ActionResult<SupervisorDetailsDTO>> GetSupervisor(string id)
        => (await _repository.ReadAsync(id)).ToActionResult();

    [Authorize]
    [HttpPost]
    [ProducesResponseType(typeof(SupervisorDetailsDTO), 201)]
    public async Task<IActionResult> Post(SuperVisorCreateDTO supervisor)
    {
        var created = await _repository.CreateAsync(supervisor);

        return CreatedAtRoute(nameof(GetSupervisor), new { created.Id }, created);
    }

    [Authorize]
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Put(string id, [FromBody] SupervisorUpdateDTO supervisor)
           => (await _repository.UpdateAsync(id, supervisor)).ToActionResult();

    [Authorize]
    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(string id)
          => (await _repository.DeleteAsync(id)).ToActionResult();
}
