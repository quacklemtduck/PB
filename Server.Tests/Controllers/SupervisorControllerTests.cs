namespace PB.Server.Tests.Controllers{

public class SupervisorControllerTests
{
    // [Fact]
    // public async Task Get_returns_Supervisors_from_repo()
    // {
    //     // Arrange
    //     var logger = new Mock<ILogger<SupervisorController>>();
    //     var expected = Array.Empty<SupervisorDetailsDTO>();
    //     var repository = new Mock<ISupervisorRepository>();
    //     repository.Setup(m => m.ReadAllAsync()).ReturnsAsync(expected);
        
    //     var controller = new SupervisorController(logger.Object, repository.Object);
    //     // Act
    //     var actual = await controller.Get();
    //     // Assert
    //     Assert.Equal(expected, actual);
    // }
    
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
        var supervisor = new SupervisorUpdateDTO("1","name");
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
        var supervisor = new SupervisorUpdateDTO("1","name");
        var repository = new Mock<ISupervisorRepository>();
        repository.Setup(m => m.UpdateAsync("1", supervisor)).ReturnsAsync(NotFound);
        var controller = new SupervisorController(logger.Object, repository.Object);

        // Act
        var response = await controller.Put("1", supervisor);

        // Assert
        Assert.IsType<NotFoundResult>(response);
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
