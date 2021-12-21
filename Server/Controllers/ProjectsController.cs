using System.Security.Claims;
using PB.Infrastructure.Authentication;
using Microsoft.AspNetCore.Identity;

namespace PB.Server.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;
        private readonly IProjectRepository _repository;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //[AllowAnonymous]
        [HttpGet]
        public async Task<IReadOnlyCollection<ProjectListDTO>> GetAll()
            => await _repository.ListAllAsync();
            
        [HttpGet]
        public async Task<IReadOnlyCollection<ProjectListDTO>> GetAllVisible()
            => await _repository.ListAllVisibleAsync();

        //[Authorize] //Supervisor

        [Authorize]
        [HttpGet]
        public async Task<IReadOnlyCollection<ProjectListDTO>> GetAllFromSupervisor()
        {
            var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //Console.WriteLine(ClaimTypes.Name);
            return await _repository.ListAllAsync(user);
        }

        [AllowAnonymous]
        [ProducesResponseType(404)]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ProjectDetailsDTO), 200)]
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<ProjectDetailsDTO>> Get(int id)
        {
            Console.WriteLine("---------------- GOT REQUEST ---------------");
            var result = await _repository.ReadByIDAsync(id);
            if (result.IsSome)
            {
                if (result.Value.Status != Status.Visible)
                {
                    var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    if (user != null)
                    {
                        Console.WriteLine($"-------KIG HER {user} -- {result.Value.Supervisor}");
                        if (user == result.Value.Supervisor)
                        {
                            return result.ToActionResult();
                        }
                    }

                    return Unauthorized();

                }
                else
                {
                    return result.ToActionResult();
                }
            }
            else
            {
                return result.ToActionResult();
            }
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(typeof(ProjectDetailsDTO), 201)]
        public async Task<IActionResult> Post(ProjectCreateDTO project)
        {
            project.Supervisor = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Console.WriteLine("----------------------------- KIG HER ---------------------------");
            Console.WriteLine(project.Supervisor);
            Console.WriteLine(project.Id);
            if(project.Id != null){
                var result = await _repository.ReadByIDAsync(project.Id.GetValueOrDefault());
                if(result != null){
                    if(User.FindFirstValue(ClaimTypes.NameIdentifier) == result.Value.Supervisor){
                        var res = await _repository.UpdateAsync(project);
                        if(res == Core.Response.Updated){
                            result = await _repository.ReadByIDAsync(project.Id.GetValueOrDefault());
                            return CreatedAtRoute("Get", new { result.Value.ID }, result.Value);
                        }
                    }
                }
            }
            var created = await _repository.CreateAsync(project);

            return CreatedAtRoute("Get", new { created.ID }, created);
        }

        //[Authorize] //Supervisor and Student
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Put(int id, [FromBody] ProjectUpdateDTO project)
               => (await _repository.UpdateAsync(project)).ToActionResult();

        //[Authorize] //Supervisor
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> DeleteProject(ProjectDeleteDTO req)
        {
            var result = await _repository.ReadByIDAsync(req.ID);
            if (result != null)
            {
                var user = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (user != null)
                {
                    if (user == result.Value.Supervisor)
                    {
                        return (await _repository.DeleteAsync(req.ID)).ToActionResult();
                    }
                }

                return Unauthorized();

            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [ProducesResponseType(404)]
        [ProducesResponseType(201)]
        public async Task<IActionResult> UpdateStatus(ProjectVisibilityUpdateDTO dto)
        {
            var res = await _repository.UpdateStatusAsync(dto);
            return res.ToActionResult();
        }
    }
}