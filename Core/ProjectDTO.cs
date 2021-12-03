namespace PB.Core;

    public record ProjectListDTO(int ID, string Title, string? Deadline);
    public record ProjectDetailsDTO(
        int ID, string Title, string? Description, string? Supervisor, string? Deadline, bool Notification, ICollection<string> ChosenStudents, ISet<string> Tags, ISet<string> Applications, ISet<string> Universities) : ProjectListDTO(ID, Title, Deadline);
    public record ProjectCreateDTO {
        public string? Title { get; set; } //TODO: not nullable

        public string? Description { get; set; }

        public string? Supervisor { get; set; } //TODO: not 0

        public string? Deadline { get; set; } //can this be a string

        public bool Notification { get; set; }

        public Status Status {get; set;} = Status.Hidden;


        public ISet<string> Tags {get; set;} = new HashSet<string>();

        public ISet<string> Universities {get; set;} = new HashSet<string>();

    }

    public record ProjectUpdateDTO : ProjectCreateDTO {
        public int ID { get; init; }
        public ISet<string> Applications { get; set; } = new HashSet<string>();

        public ICollection<string> ChosenStudents {get; set;}  = new HashSet<string>();

    }

