namespace PB.Core;

    public record ProjectListDTO(int ID, string Title, string? Deadline);
    public record ProjectDetailsDTO(
        int ID, string Title, string? Description, string? Supervisor, string? Deadline, bool getNotification, int numberOfStudents, ICollection<string> CollabStudents, ISet<string> Tags, ISet<string> Applications, ISet<string> Universities) : ProjectListDTO(ID, Title, Deadline);
    public record ProjectCreateDTO {
        public string? Title { get; set; } //TODO: not nullable

        public string? Description { get; set; }

        public string? Supervisor { get; set; } //TODO: not 0

        public string? Deadline { get; set; } //can this be a string

        public bool getNotification { get; set; }

        public int numberOfStudents {get; set;}

        public Status status {get; set;} = Status.Hidden;

        public ICollection<string> CollabStudents {get; set;}  = new HashSet<string>();

        public ISet<string> Tags {get; set;} = new HashSet<string>();

        public ISet<string> Applications { get; set; } = new HashSet<string>();

        public ISet<string> Universities {get; set;} = new HashSet<string>();

    }

    public record ProjectUpdateDTO : ProjectCreateDTO {
        public int ID { get; init; }
    }

