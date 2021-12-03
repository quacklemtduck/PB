namespace PB.Infrastructure{
    public class University
    {
        
        [StringLength(50)]
        public string? Name {get; set;}

        [StringLength(10)]
        [Key]
        public string? Id {get; set;}

        public ICollection<Education> Educations { get; set; } = new HashSet<Education>();

        public ICollection<int> GetEducationIDs()
        {
            ICollection<int> EducationtIDList = new List<int>();
            if (Educations != null)
            {
                foreach (Education e in Educations)
                {
                    EducationtIDList.Add(e.Id);
                }
            }
            return EducationtIDList;
        }

    }

    
}
