namespace PB.Infrastructure
{


    public class Project
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        public string? Description { get; set; }
        public string SupervisorID { get; set; }
        public Supervisor Supervisor { get; set; }
        public bool Notification { get; set; }
        public Status Status { get; set; }

        public ICollection<Application> Applications { get; set; } = new HashSet<Application>();
        public ICollection<Education> Educations { get; set; } = new HashSet<Education>();

        public ICollection<Student> ChosenStudents { get; set; } = new HashSet<Student>();
    }
}
