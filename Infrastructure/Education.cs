namespace PB.Infrastructure
{
    public class Education
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Grade { get; set; }

        public University? University { get; set; }

        public ICollection<Project> Projects { get; set; } = new HashSet<Project>();
    }
}
