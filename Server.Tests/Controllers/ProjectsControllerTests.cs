namespace PB.Server.Tests.Controllers
{

    public class ProjectsControllerTests
    {
        [Fact]
        public async Task Create_creates_Project()
        {
            // Arrange
            var university = new University { Name = "Københavns Universitet", Abbreviation = "KU" };
            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };

            var logger = new Mock<ILogger<ProjectsController>>();
            var toCreate = new ProjectCreateDTO();
            var created = new ProjectDetailsDTO(1, "Project1", "This is project 1", supervisor.Name, null, false, new HashSet<string>(), new HashSet<string>(), new HashSet<string>(), new HashSet<string>());
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.CreateAsync(toCreate)).ReturnsAsync(created);
            var controller = new ProjectsController(logger.Object, repository.Object);

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
            var expected = Array.Empty<ProjectDetailsDTO>();
            var repository = new Mock<IProjectRepository>();

            repository.Setup(m => m.ListAllAsync()).ReturnsAsync(expected);

            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var actual = await controller.GetAll();

            // Assert
            Assert.Equal(expected, actual);
        }

        public async Task Get_returns_Supervisors_projects_from_repo()
        {
            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };

            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var expected = Array.Empty<ProjectDetailsDTO>();
            var repository = new Mock<IProjectRepository>();

            repository.Setup(m => m.ListAllAsync()).ReturnsAsync(expected);

            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var actual = await controller.GetAll(supervisor.Id);

            // Assert
            Assert.Equal(expected, actual);
        }

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
            var university = new University { Name = "Københavns Universitet", Abbreviation = "KU" };
            var supervisor = new Supervisor { Id = 1, Name = "Supervisor1", Email = "supervisor1@email.com", Password = "***", ContactInfo = "info1", Projects = new List<Project>() };

            var logger = new Mock<ILogger<ProjectsController>>();
            var repository = new Mock<IProjectRepository>();
            var project = new ProjectDetailsDTO(1, "Project1", "This is project 1", supervisor.Name, null, false, new HashSet<string>(), new HashSet<string>(), new HashSet<string>(), new HashSet<string>());
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
            repository.Setup(m => m.UpdateAsync(1, project)).ReturnsAsync(Updated);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Put(1, project);

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
            repository.Setup(m => m.UpdateAsync(1, project)).ReturnsAsync(NotFound);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Put(1, project);

            // Assert
            Assert.IsType<NotFoundResult>(response);
        }

        /*[Fact]
        public async Task Delete_given_non_existing_returns_NotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.DeleteAsync(42)).ReturnsAsync(Status.NotFound);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Delete(42);

            // Assert
            Assert.IsType<NotFoundResult>(response);
        }

        [Fact]
        public async Task Delete_given_existing_returns_NoContent()
        {
            // Arrange
            var logger = new Mock<ILogger<ProjectsController>>();
            var repository = new Mock<IProjectRepository>();
            repository.Setup(m => m.DeleteAsync(1)).ReturnsAsync(Status.Deleted);
            var controller = new ProjectsController(logger.Object, repository.Object);

            // Act
            var response = await controller.Delete(1);

            // Assert
            Assert.IsType<NoContentResult>(response);
        }*/
    }

}

