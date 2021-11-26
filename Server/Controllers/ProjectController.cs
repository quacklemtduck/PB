/*namespace PB.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
public class ProjectsController : ControllerBase
{
    private readonly ILogger<ProjectsController> _logger;
    private readonly IProjectRepository _repository;

    public ProjectsController(ILogger<ProjectsController> logger, IProjectRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IReadOnlyCollection<ProjectListDTO>> Get()
        => await _repository.ListAllAsync();

    [AllowAnonymous]
    [ProducesResponseType(404)]
    [ProducesResponseType(typeof(ProjectDetailsDTO), 200)]
    [HttpGet("{id}")]
    public async Task<ActionResult<ProjectDetailsDTO>> Get(int id)
        => (await _repository.ReadByIDAsync(id)).ToActionResult();

    [Authorize]
    [HttpPost]
    [ProducesResponseType(typeof(ProjectDetailsDTO), 201)]
    public async Task<IActionResult> Post(ProjectCreateDTO project)
    {
        var created = await _repository.CreateAsync(project);

        return CreatedAtRoute(nameof(Get), new { created.ID }, created);
    }

    [Authorize]
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Put(int id, [FromBody] ProjectUpdateDTO project)
           => (await _repository.UpdateAsync(id, project)).ToActionResult();

    [Authorize]
    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Delete(int id)
          => (await _repository.DeleteAsync(id)).ToActionResult();
}*/