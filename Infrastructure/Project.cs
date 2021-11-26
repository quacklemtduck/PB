namespace PB.Infrastructure
{


    public class Project
    {
        public int Id { get; set; } //PK
        public string Title { get; set; }
        public string? Description { get; set; }
        public int SupervisorID { get; set; } //FK
        public Supervisor Supervisor { get; set; }
        public DateTime? Deadline { get; set; }
        public bool Notification { get; set; }
        public Status Status { get; set; }

        public ICollection<Application> Applications { get; set; } = new HashSet<Application>(); //FK's
        public ICollection<University> Universities { get; set; } = new HashSet<University>(); //FK's
        
        public ICollection<Student> ChosenStudents { get; set; } = new HashSet<Student>(); //FK's
        public ICollection<Tag> Tags { get; set; } = new HashSet<Tag>(); //FK's
        

    }
}
