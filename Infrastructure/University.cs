namespace PB.Infrastructure{
    public class University
    {
        public int Id {get; set;}
        
        [StringLength(50)]
        public string Name {get; set;}

        [StringLength(10)]
        public string Abbreviation {get; set;}

    }

    
}
