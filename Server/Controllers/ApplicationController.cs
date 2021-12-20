using System.Security.Claims;

namespace PB.Server.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]/[action]")]
//[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
public class ApplicationController : ControllerBase
{
    private readonly ILogger<ApplicationController> _logger;
    private readonly IApplicationRepository _ApplicationRepository;
    private readonly IProjectRepository _ProjectRepository;

    public ApplicationController(ILogger<ApplicationController> logger, IApplicationRepository applicationRepository, IProjectRepository projectRepository)
    {
        _logger = logger;
        _ApplicationRepository = applicationRepository;
        _ProjectRepository = projectRepository;
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IReadOnlyCollection<ApplicationDetailsDTO>> Get()
        => await _ApplicationRepository.ReadAllAsync();

    [AllowAnonymous]
    [ProducesResponseType(404)]
    [ProducesResponseType(typeof(ApplicationDetailsDTO), 200)]
    [HttpGet("{id}")]
    public async Task<ActionResult<ApplicationDetailsDTO>> Get(int id)
        => (await _ApplicationRepository.ReadAsync(id)).ToActionResult();

    [Authorize]
    [HttpPost]
    [ProducesResponseType(typeof(ApplicationDetailsDTO), 201)]
    public async Task<IActionResult> Post(ApplicationCreateDTO application)
    {
        var created = await _ApplicationRepository.CreateAsync(application);

        return CreatedAtRoute(nameof(Get), new { created.Id }, created);
    }

    [Authorize]
    [HttpGet("{id}", Name = "GetFromProject")]
    public async Task<ActionResult<IReadOnlyCollection<ApplicationDetailsDTO>>> GetFromProject(int id){
        var project = await _ProjectRepository.ReadByIDAsync(id);
        if(project.IsSome){
            if(project.Value.Supervisor == User.FindFirstValue(ClaimTypes.NameIdentifier)){
                var result = await _ApplicationRepository.ReadFromProject(id);
                return result.ToList();
            }else{
                return Unauthorized();
            }
        }else{
            return new NotFoundResult();
        }
    }

    [Authorize]
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Put(int id, [FromBody] ApplicationUpdateDTO application)
           => (await _ApplicationRepository.UpdateAsync(id, application)).ToActionResult();

}
