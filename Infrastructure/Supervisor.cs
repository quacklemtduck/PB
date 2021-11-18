namespace PBInfrastructure;

public class Supervisor
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Name {get; set;}

    [StringLength(50)]
    [EmailAddress]
    public string Email {get; set;}

    [StringLength(50)]
    public string Password {get; set;}

    [StringLength(100)]
    public string ContactInfo {get; set;}
    public ICollection<Project>? Projects {get; set;}

    public Supervisor(string _name, string _email, string _password, string _contactInfo){
        Name = _name;
        Email = _email;
        Password = _password;
        ContactInfo = _contactInfo;
    }

}