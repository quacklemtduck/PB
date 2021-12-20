namespace PB.Core;

    public record ProjectListDTO(int ID, string Title, string Description, Status Status);
    public record ProjectVisibilityUpdateDTO(int ID, Status Status);
    public record ProjectChosenStudentsUpdateDTO(int ID, ICollection<int> ChosenStudents);
    public record ProjectDetailsDTO(
        int ID, string Title, string? Description, string? Supervisor, bool Notification, ICollection<int> ChosenStudents, ISet<int> Applications, ISet<int> Educations, Status Status);
    public record ProjectCreateDTO {
        public int? Id {get; set;}
        public string? Title { get; set; } //TODO: not nullable

        public string? Description { get; set; }

        public string? Supervisor { get; set; }

        //public string? Deadline { get; set; } //can this be a string

        public bool Notification { get; set; }

        public Status Status {get; set;} = Status.Hidden;


        //public ISet<string> Tags {get; set;} = new HashSet<string>();

        public ISet<int> Educations {get; set;} = new HashSet<int>();

    }

    public record ProjectUpdateDTO : ProjectCreateDTO {
        public int ID { get; init; }
        public ISet<int> Applications { get; set; } = new HashSet<int>();

        public ICollection<int> ChosenStudents {get; set;}  = new HashSet<int>();

    }

    public record ProjectDeleteDTO{
        public int ID {get; init;}
    }

