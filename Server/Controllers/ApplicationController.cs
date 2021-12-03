namespace PB.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
//[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
public class ApplicationController : ControllerBase
{
    private readonly ILogger<ApplicationController> _logger;
    private readonly IApplicationRepository _repository;

    public ApplicationController(ILogger<ApplicationController> logger, IApplicationRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IReadOnlyCollection<ApplicationDetailsDTO>> Get()
        => await _repository.ReadAllAsync();

    [AllowAnonymous]
    [ProducesResponseType(404)]
    [ProducesResponseType(typeof(ApplicationDetailsDTO), 200)]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApplicationDetailsDTO>> Get(int id)
        => (await _repository.ReadAsync(id)).ToActionResult();

    [Authorize]
    [HttpPost]
    [ProducesResponseType(typeof(ApplicationDetailsDTO), 201)]
    public async Task<IActionResult> Post(ApplicationCreateDTO application)
    {
        var created = await _repository.CreateAsync(application);

        return CreatedAtRoute(nameof(Get), new { created.Id }, created);
    }

    [Authorize]
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Put(int id, [FromBody] ApplicationUpdateDTO application)
           => (await _repository.UpdateAsync(id, application)).ToActionResult();

}
