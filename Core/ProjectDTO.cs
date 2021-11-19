namespace PB.Core;

    public record ProjectListDTO(int ID, string Title, string? Deadline);
    public record ProjectDetailsDTO(
        int ID, string Title, string? Description, int SupervisorID, string? Email, string? Deadline, bool getNotification, int numberOfStudents, ICollection<string> CollabStudents, ISet<string> Tags, ISet<string> Applications, ISet<string> Universities) : ProjectListDTO(ID, Title, Deadline);
    public record ProjectCreateDTO {
        public string? Title { get; set; } //TODO: not nullable

        public string? Description { get; set; }

        public int SupervisorID { get; set; } //TODO: not 0

        [EmailAddress]
        public string? Email { get; set; } //TODO: not 0

        public string? Deadline { get; set; } //can this be a string

        public bool getNotification { get; set; }

        public int numberOfStudents {get; set;}

        public ICollection<int> CollabStudents {get; set;}  = new HashSet<int>();

        public ISet<string> Tags {get; set;} = new HashSet<string>();

        public ISet<int> Applications { get; set; } = new HashSet<int>();

        public ISet<string> Universities {get; set;} = new HashSet<string>();

    }

    public record ProjectUpdateDTO : ProjectCreateDTO {
        public int ID { get; init; }
    }

