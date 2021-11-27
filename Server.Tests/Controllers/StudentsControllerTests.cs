namespace PB.Server.Tests.Controllers{

public class StudentsControllerTests
{
    [Fact]
    public async Task Create_creates_Student()
    {
        // Arrange
        var university = new University {Name = "Københavns Universitet", Abbreviation = "KU"};

        var logger = new Mock<ILogger<StudentsController>>();
        var toCreate = new StudentCreateDTO();
        var created = new StudentDetailsDTO(1, "Clark", university.Name, "Clark@gmail.com", new HashSet<string>(), new HashSet<string>());
        var repository = new Mock<IStudentRepository>();
        repository.Setup(m => m.CreateAsync(toCreate)).ReturnsAsync(created);
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var result = await controller.Post(toCreate) as CreatedAtRouteResult;

        // Assert
        Assert.Equal(created, result?.Value);
        Assert.Equal("Get", result?.RouteName);
        //Assert.Equal(KeyValuePair.Create("Id", (object?)1), result?.RouteValues?.Single());
        Assert.Equal((object?)1, result?.RouteValues?.GetValueOrDefault("Id"));
    }

    [Fact]
    public async Task Get_returns_Students_from_repo()
    {
        // Arrange
        var logger = new Mock<ILogger<StudentsController>>();
        var expected = Array.Empty<StudentDetailsDTO>();
        var repository = new Mock<IStudentRepository>();

        repository.Setup(m => m.ReadAllAsync()).ReturnsAsync(expected);
        
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var actual = await controller.Get();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public async Task Get_given_non_existing_returns_NotFound()
    {
        // Arrange
        var logger = new Mock<ILogger<StudentsController>>();
        var repository = new Mock<IStudentRepository>();
        repository.Setup(m => m.ReadAsync(42)).ReturnsAsync(default(StudentDetailsDTO));
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var response = await controller.Get(42);

        // Assert
        Assert.IsType<NotFoundResult>(response.Result);
    }

    [Fact]
    public async Task Get_given_existing_returns_student()
    {
        // Arrange
        var university = new University {Name = "Københavns Universitet", Abbreviation = "KU"};

        var logger = new Mock<ILogger<StudentsController>>();
        var repository = new Mock<IStudentRepository>();
        var student = new StudentDetailsDTO(1, "Clark", university.Name, "Clark@gmail.com", new HashSet<string>(), new HashSet<string>());
        repository.Setup(m => m.ReadAsync(1)).ReturnsAsync(student);
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var response = await controller.Get(1);

        // Assert
        Assert.Equal(student, response.Value);
    }

    [Fact]
    public async Task Put_updates_Student()
    {
        // Arrange
        var logger = new Mock<ILogger<StudentsController>>();
        var student = new StudentUpdateDTO();
        var repository = new Mock<IStudentRepository>();
        repository.Setup(m => m.UpdateAsync(1, student)).ReturnsAsync(Updated);
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var response = await controller.Put(1, student);

        // Assert
        Assert.IsType<NoContentResult>(response);
    }

    [Fact]
    public async Task Put_given_unknown_id_returns_NotFound()
    {
        // Arrange
        var logger = new Mock<ILogger<StudentsController>>();
        var student = new StudentUpdateDTO();
        var repository = new Mock<IStudentRepository>();
        repository.Setup(m => m.UpdateAsync(1, student)).ReturnsAsync(NotFound);
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var response = await controller.Put(1, student);

        // Assert
        Assert.IsType<NotFoundResult>(response);
    }

    /*[Fact]
    public async Task Delete_given_non_existing_returns_NotFound()
    {
        // Arrange
        var logger = new Mock<ILogger<StudentsController>>();
        var repository = new Mock<IStudentRepository>();
        repository.Setup(m => m.DeleteAsync(42)).ReturnsAsync(Status.NotFound);
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var response = await controller.Delete(42);

        // Assert
        Assert.IsType<NotFoundResult>(response);
    }

    [Fact]
    public async Task Delete_given_existing_returns_NoContent()
    {
        // Arrange
        var logger = new Mock<ILogger<StudentsController>>();
        var repository = new Mock<IStudentRepository>();
        repository.Setup(m => m.DeleteAsync(1)).ReturnsAsync(Status.Deleted);
        var controller = new StudentsController(logger.Object, repository.Object);

        // Act
        var response = await controller.Delete(1);

        // Assert
        Assert.IsType<NoContentResult>(response);
    }*/
}

}

