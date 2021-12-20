using PB.Infrastructure.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace PB.Server.Tests.Controllers
{

    public class ProjectsControllerTests
    {
        [Fact]
        public async Task Create_creates_Project()
        {
            // Arrange
            var university = new University { Name = "Københavns Universitet", Id = "KU" };
            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };

            var logger = new Mock<ILogger<ProjectsController>>();
            var toCreate = new ProjectCreateDTO();
            var created = new ProjectDetailsDTO(1, "Project1", "This is project 1", supervisor.Name, false, new HashSet<int>(), new HashSet<int>(), new HashSet<int>(), Status.Visible);
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.CreateAsync(toCreate)).ReturnsAsync(created);
            var controller = new ProjectsController(logger.Object, repository.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[] {
                                        new Claim(ClaimTypes.NameIdentifier, "1"),
                                        new Claim(ClaimTypes.Name, "Supervisor1")
                                        // other required and custom claims
                                   },"TestAuthentication"));

            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = new DefaultHttpContext{User = user};

            // Act
            var result = await controller.Post(toCreate) as CreatedAtRouteResult;

            // Assert
            Assert.Equal(created, result?.Value);
            Assert.Equal("Get", result?.RouteName);
            //Assert.Equal(KeyValuePair.Create("Id", (object?)1), result?.RouteValues?.Single());
            Assert.Equal((object?)1, result?.RouteValues?.GetValueOrDefault("Id"));
        }

       [Fact]
        public async Task Get_returns_Projects_from_repo()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var expected = Array.Empty<ProjectListDTO>();
            var repository = new Mock<IProjectRepository>();
            
            repository.Setup(m => m.ListAllAsync()).ReturnsAsync(expected);
            

            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var actual = await controller.GetAll();

            // Assert
            Assert.Equal(expected, actual);
        }

        // [Fact]
        // public async Task Get_returns_Supervisors_projects_from_repo()
        // {
        //     var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };

        //     // Arrange
        //     var logger = new Mock<ILogger<ProjectsController>>();
        //     var expected = Array.Empty<ProjectListDTO>();
        //     var repository = new Mock<IProjectRepository>();

        //     repository.Setup(m => m.ListAllAsync()).ReturnsAsync(expected);

        //     var controller = new ProjectsController(logger.Object, repository.Object);

        //     // Act
        //     var actual = await controller.GetAllFromSupervisor();
        //     Console.WriteLine("----------------------------- 7 ---------------------------");

        //     // Assert
        //     Assert.Equal(expected, actual);
        // }

        [Fact]
        public async Task Get_given_non_existing_returns_NotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.ReadByIDAsync(42)).ReturnsAsync(default(ProjectDetailsDTO));
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Get(42);

            // Assert
            Assert.IsType<NotFoundResult>(response.Result);
        }

        [Fact]
        public async Task Get_given_existing_returns_project()
        {
            // Arrange
            var university = new University { Name = "Københavns Universitet", Id = "KU" };
            var supervisor = new Supervisor { Id = "1", Name = "Supervisor1", Email = "supervisor1@email.com", Projects = new List<Project>() };

            var logger = new Mock<ILogger<ProjectsController>>();
            var repository = new Mock<IProjectRepository>();
            var project = new ProjectDetailsDTO(1, "Project1", "This is project 1", supervisor.Name, false, new HashSet<int>(), new HashSet<int>(), new HashSet<int>(), Status.Visible);
            repository.Setup(m => m.ReadByIDAsync(1)).ReturnsAsync(project);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Get(1);

            // Assert
            Assert.Equal(project, response.Value);
        }

        [Fact]
        public async Task Put_updates_Project()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var project = new ProjectUpdateDTO();
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.UpdateAsync(project)).ReturnsAsync(Updated);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Put(1, project);

            // Assert
            Assert.IsType<NoContentResult>(response);
        }

        [Fact]
        public async Task UpdateStatus_Project()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var project = new ProjectVisibilityUpdateDTO(1, Status.Closed);
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.UpdateStatusAsync(project)).ReturnsAsync(Updated);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.UpdateStatus(project);

            // Assert
            Assert.IsType<NoContentResult>(response);
        }

        [Fact]
        public async Task ChoseStudents_Project()
        {
            
            // Arrange
            var student = new Student { Name = "student1", Email = "student1@gmail.com", University = new University{Name = "Københavns Universitet", Id = "KU"} };
            var students = new HashSet<int>();
            students.Add(student.Id);

            var logger = new Mock<ILogger<ProjectsController>>();
            var project = new ProjectChosenStudentsUpdateDTO(1, students);
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.UpdateChosenStudentsAsync(project)).ReturnsAsync(Updated);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.UpdateChosenStudents(project);

            // Assert
            Assert.IsType<NoContentResult>(response);
        }

        [Fact]
        public async Task Put_given_unknown_id_returns_NotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var project = new ProjectUpdateDTO();
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.UpdateAsync(project)).ReturnsAsync(NotFound);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Put(1, project);

            // Assert
            Assert.IsType<NotFoundResult>(response);
        }

        [Fact]
        public async Task Delete_given_non_existing_returns_NotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.DeleteAsync(42)).ReturnsAsync(Response.NotFound);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.DeleteProject(new ProjectDeleteDTO{ID = 42});

            // Assert
            Assert.IsType<NotFoundResult>(response);
        }
    }

}

