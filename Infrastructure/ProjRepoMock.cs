namespace PB.Infrastructure
{

public class ProjRepoMock 
{

        public List<Project> ListAll()
        {
            List<Project> mockProjects = new List<Project>();

            Project p1 = new Project{Id=1, Title="Example Project1"};
            Project p2 = new Project{Id=1, Title="Example Project2"};
            Project p3 = new Project{Id=1, Title="Example Project3"};
            Project p4 = new Project{Id=1, Title="Example Project4"};
            Project p5 = new Project{Id=1, Title="Example Project5"};
            Project p6 = new Project{Id=1, Title="Example Project6"};
            Project p7 = new Project{Id=1, Title="Example Project7"};
            Project p8 = new Project{Id=1, Title="Example Project8"};
            Project p9 = new Project{Id=1, Title="Example Project9"};
            Project p10 = new Project{Id=1, Title="Example Project10"};
            Project p11 = new Project{Id=1, Title="Example Project11"};
            Project p12 = new Project{Id=1, Title="Example Project12"};
            Project p13 = new Project{Id=1, Title="Example Project13"};
            Project p14 = new Project{Id=1, Title="Example Project14"};



            mockProjects.Add(p1);
            mockProjects.Add(p2);
            mockProjects.Add(p3);
            mockProjects.Add(p4);
            mockProjects.Add(p5);
            mockProjects.Add(p6);
            mockProjects.Add(p7);
            mockProjects.Add(p8);
            mockProjects.Add(p9);
            mockProjects.Add(p10);
            mockProjects.Add(p11);
            mockProjects.Add(p12);
            mockProjects.Add(p13);
            mockProjects.Add(p14);
            return mockProjects;
        }

   }
}