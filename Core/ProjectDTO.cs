namespace Core;

    public record ProjectDTO();

    public record ProjectListDTO() : ProjectDTO();
    public record ProjectDetailsDTO() : ProjectDTO();
    public record ProjectCreateDTO {

    }

    public record ProjectUpdateDTO : ProjectDTO {
        //TODO: do we have to have this??
    }

    public record ProjectUpdateStateDTO : ProjectDTO {

    }

    public record ProjectUpdateApplicationDTO : ProjectDTO {

    }

