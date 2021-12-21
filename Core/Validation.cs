namespace PB.Core;

public class Validation
{
    public static ValidationResult? ValidateProject(string title, ValidationContext validationContext)
    {
        var project = (ProjectCreateDTO)validationContext.ObjectInstance;
        var names = new[]
        {
                title,
                project.Description
            };
        if (names.Any(string.IsNullOrWhiteSpace))
        {
            return new ValidationResult("A title and description, must be supplied to create a new project", new[] { nameof(ProjectDetailsDTO.Title) });
        }
        return ValidationResult.Success;
    }

}