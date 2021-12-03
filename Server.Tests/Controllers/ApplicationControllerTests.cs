namespace PB.Server.Tests.Controllers{

public class ApplicationControllerTests
{
    [Fact]
    public async Task Create_creates_application()
    {
        // Arrange

        var logger = new Mock<ILogger<ApplicationController>>();
        var toCreate = new ApplicationCreateDTO(1,1,"title");
        var created = new ApplicationDetailsDTO(1, 1,1,null, "title");
        var repository = new Mock<IApplicationRepository>();
        repository.Setup(m => m.CreateAsync(toCreate)).ReturnsAsync(created);
        var controller = new ApplicationController(logger.Object, repository.Object);

        // Act
        var result = await controller.Post(toCreate) as CreatedAtRouteResult;

        // Assert
        Assert.Equal(created, result?.Value);
        Assert.Equal("Get", result?.RouteName);
        Assert.Equal(KeyValuePair.Create("Id", (object?)1), result?.RouteValues?.Single());
        Assert.Equal((object?)1, result?.RouteValues?.GetValueOrDefault("Id"));
    }

    [Fact]
    public async Task Get_returns_Applications_from_repo()
    {
        // Arrange
        var logger = new Mock<ILogger<ApplicationController>>();
        var expected = Array.Empty<ApplicationDetailsDTO>();
        var repository = new Mock<IApplicationRepository>();
        repository.Setup(m => m.ReadAllAsync()).ReturnsAsync(expected);
        
        var controller = new ApplicationController(logger.Object, repository.Object);
        // Act
        var actual = await controller.Get();
        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public async Task Get_given_non_existing_returns_NotFound()
    {
        // Arrange
        var logger = new Mock<ILogger<ApplicationController>>();
        var repository = new Mock<IApplicationRepository>();
        repository.Setup(m => m.ReadAsync(42)).ReturnsAsync(default(ApplicationDetailsDTO));
        var controller = new ApplicationController(logger.Object, repository.Object);

        // Act
        var response = await controller.Get(42);

        // Assert
        Assert.IsType<NotFoundResult>(response.Result);
    }
    
    [Fact]
    public async Task Get_given_existing_returns_application()
    {
        // Arrange
        var logger = new Mock<ILogger<ApplicationController>>();
        var repository = new Mock<IApplicationRepository>();
        var application = new ApplicationDetailsDTO(1, 1, 1, null,"title");
        repository.Setup(m => m.ReadAsync(1)).ReturnsAsync(application);
        var controller = new ApplicationController(logger.Object, repository.Object);

        // Act
        var response = await controller.Get(1);

        // Assert
        Assert.Equal(application, response.Value);
    }
    
    [Fact]
    public async Task Put_updates_Application()
    {
        // Arrange
        var logger = new Mock<ILogger<ApplicationController>>();
        var application = new ApplicationUpdateDTO(1,"description","title2");
        var repository = new Mock<IApplicationRepository>();
        repository.Setup(m => m.UpdateAsync(1, application)).ReturnsAsync(Updated);
        var controller = new ApplicationController(logger.Object, repository.Object);

        // Act
        var response = await controller.Put(1, application);

        // Assert
        Assert.IsType<NoContentResult>(response);
    }
    
    [Fact]
    public async Task Put_given_unknown_id_returns_NotFound()
    {
        // Arrange
        var logger = new Mock<ILogger<ApplicationController>>();
        var application = new ApplicationUpdateDTO(1,"description","description");
        var repository = new Mock<IApplicationRepository>();
        repository.Setup(m => m.UpdateAsync(1, application)).ReturnsAsync(NotFound);
        var controller = new ApplicationController(logger.Object, repository.Object);

        // Act
        var response = await controller.Put(1, application);

        // Assert
        Assert.IsType<NotFoundResult>(response);
    }
}

}
