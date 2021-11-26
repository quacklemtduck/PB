namespace PB.Infrastructure
{
    public class Tag
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string TagName { get; set; }


    }


}