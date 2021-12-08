namespace PB.Core;

    public record ProjectListDTO(int ID, string Title, string Description);
    public record ProjectDetailsDTO(
        int ID, string Title, string? Description, string? Supervisor, bool Notification, ICollection<string> ChosenStudents, ISet<string> Applications, ISet<int> Educations, Status Status);
    public record ProjectCreateDTO {
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
        public ISet<string> Applications { get; set; } = new HashSet<string>();

        public ICollection<string> ChosenStudents {get; set;}  = new HashSet<string>();

    }

