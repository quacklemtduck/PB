namespace PB.Infrastructure
{


    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string? Description { get; set; }
        public int SupervisorID { get; set; } //TODO: not 0
        public Supervisor Supervisor { get; set; }
        public DateTime? Deadline { get; set; }
        public bool getNotification { get; set; }
        public int numberOfStudents { get; set; }
        public ICollection<Student> CollabStudents { get; set; } = new HashSet<Student>();
        public ICollection<Tag> Tags { get; set; } = new HashSet<Tag>();
        public ICollection<Application> Applications { get; set; } = new HashSet<Application>();
        public ICollection<University> Universities { get; set; } = new HashSet<University>();

    }
}
