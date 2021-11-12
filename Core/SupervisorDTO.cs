namespace Core;

public record SupervisorUpdateDTO(int Id, ICollection<int>? Projects);

public record SupervisorDetailsDTO(int Id, string Name, string Email, ICollection<int>? Projects);

public record SuperVisorCreateDTO{

    [StringLength(50)]
    public string Name {get; set;} 

    [StringLength(50)]
    [EmailAddress]
    public string Email {get; set;}

    [StringLength(50)]
    public string Password {get; set;}

    [StringLength(100)]
    public string ContactInfo {get; set;}

    public SuperVisorCreateDTO(string _name, string _email, string _password, string _contactInfo){
        Name = _name;
        Email = _email;
        Password = _password;
        ContactInfo = _contactInfo;
    }
}