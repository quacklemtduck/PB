namespace PB.Server.Tests.Controllers
{
    public class SupervisorControllerTests
    {
        [Fact]
        public async Task Create_creates_Supervisor()
        {
            // Arrange    
            var university = new University { Name = "Københavns Universitet", Id = "KU" };
            var logger = new Mock<ILogger<SupervisorController>>();
            var toCreate = new SuperVisorCreateDTO("1", "Clark", "clark@gmail.com");
            var created = new SupervisorDetailsDTO("1", "Clark", "clark@gmail.com", new HashSet<int>());
            var repository = new Mock<ISupervisorRepository>();

            repository.Setup(m => m.CreateAsync(toCreate)).ReturnsAsync(created);
            var controller = new SupervisorController(logger.Object, repository.Object);

            // Act
            var result = await controller.Post(toCreate) as CreatedAtRouteResult;

            // Assert
            Assert.Equal(created, result?.Value);
            Assert.Equal("GetSupervisor", result?.RouteName);
            Assert.Equal((object?)"1", result?.RouteValues?.GetValueOrDefault("Id"));
        }

        [Fact]
        public async Task Get_given_existing_returns_supervisor()
        {
            // Arrange
            var logger = new Mock<ILogger<SupervisorController>>();
            var repository = new Mock<ISupervisorRepository>();
            var supervisor = new SupervisorDetailsDTO("1", "supervisor", "supervisor@gmail.com", new HashSet<int>());
            repository.Setup(m => m.ReadAsync("1")).ReturnsAsync(supervisor);
            var controller = new SupervisorController(logger.Object, repository.Object);

            // Act
            var response = await controller.GetSupervisor("1");

            // Assert
            Assert.Equal(supervisor, response.Value);
        }

        [Fact]
        public async Task Put_updates_Supervisor()
        {
            // Arrange
            var logger = new Mock<ILogger<SupervisorController>>();
            var supervisor = new SupervisorUpdateDTO("1", "name");
            var repository = new Mock<ISupervisorRepository>();
            repository.Setup(m => m.UpdateAsync("1", supervisor)).ReturnsAsync(Updated);
            var controller = new SupervisorController(logger.Object, repository.Object);

            // Act
            var response = await controller.Put("1", supervisor);

            // Assert
            Assert.IsType<NoContentResult>(response);
        }

        [Fact]
        public async Task Put_given_unknown_id_returns_NotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<SupervisorController>>();
            var supervisor = new SupervisorUpdateDTO("1", "name");
            var repository = new Mock<ISupervisorRepository>();
            repository.Setup(m => m.UpdateAsync("1", supervisor)).ReturnsAsync(NotFound);
            var controller = new SupervisorController(logger.Object, repository.Object);

            // Act
            var response = await controller.Put("1", supervisor);

            // Assert
            Assert.IsType<NotFoundResult>(response);
        }


        [Fact]
        public async Task Get_given_non_existing_returns_NotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<SupervisorController>>();
            var repository = new Mock<ISupervisorRepository>();
            repository.Setup(m => m.ReadAsync("42")).ReturnsAsync(default(SupervisorDetailsDTO));
            var controller = new SupervisorController(logger.Object, repository.Object);

            // Act
            var response = await controller.GetSupervisor("42");

            // Assert
            Assert.IsType<NotFoundResult>(response.Result);


        }

        [Fact]
        public async Task Delete_given_non_existing_returns_NotFound()
        {
            // Arrange
            var logger = new Mock<ILogger<SupervisorController>>();
            var repository = new Mock<ISupervisorRepository>();
            repository.Setup(m => m.DeleteAsync("42")).ReturnsAsync(NotFound);
            var controller = new SupervisorController(logger.Object, repository.Object);
            // Act
            var response = await controller.Delete("42");
            // Assert
            Assert.IsType<NotFoundResult>(response);
        }

        [Fact]
        public async Task Delete_given_existing_returns_NoContent()
        {
            // Arrange
            var logger = new Mock<ILogger<SupervisorController>>();
            var repository = new Mock<ISupervisorRepository>();
            repository.Setup(m => m.DeleteAsync("1")).ReturnsAsync(Deleted);
            var controller = new SupervisorController(logger.Object, repository.Object);
            // Act
            var response = await controller.Delete("1");
            // Assert
            Assert.IsType<NoContentResult>(response);
        }
    }

}
