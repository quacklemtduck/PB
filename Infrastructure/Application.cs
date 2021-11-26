namespace PB.Infrastructure
{
    public class Application
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string? Description { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }


    }
}