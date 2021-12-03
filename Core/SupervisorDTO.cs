namespace PB.Core;

public record SupervisorUpdateDTO(int Id, String Name);

public record SupervisorDetailsDTO(int Id, string Name, string Email, ICollection<int> Projects);

public record SuperVisorCreateDTO{

    [StringLength(50)]
    public string Name {get; set;} 
    [StringLength(255)]
    [EmailAddress]
    public string Email {get; set;}
    public ICollection<int> Projects {get; set;}  = new HashSet<int>();

    public SuperVisorCreateDTO(string _name, string _email){
        Name = _name;
        Email = _email;
    }
}