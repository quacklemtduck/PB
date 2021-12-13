namespace Infastructure.Tests
{
    public class EmailSenderTests
    {
        [Fact]
        public async Task Using_SendMailAsync_sends_mail()
        {
            var rand = new Random();
            var mailsubject = "mailsubjecttest"+rand.Next(1000);
            await EmailSender.SendMailAsync("unibanken@gmail.com",mailsubject,"this is the body of the email");
            using var client = new Pop3Client();
            client.Connect("smtp.gmail.com", 995, true);
            //insert password
            client.Authenticate("unibanken@gmail.com", "@9^BVqx}$E<M{VAt");
            Assert.Equal(mailsubject, client.GetMessage(client.Count - 1).Subject);
        }

        [Fact]
        public async Task SendNewApplicationNotificationAsync_Sends_Notification_To_Supervisor()
        {
            var student = new Student{Id = 1,Name = "student1", Email = "student1@gmail.com"};
            var supervisor = new Supervisor{Id = "1", Name = "Supervisor1", Email = "unibanken@gmail.com", Projects = new List<Project>()};
            var project = new Project { Id = 1, Title = "Project1", Description = "This is project 1", Supervisor = supervisor, Notification = true };
            var application = new Application { Id = 1, Title = "title1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore.", Student = student, Project = project };
            await EmailSender.SendNewApplicationNotificationAsync(application);
            using var client = new Pop3Client();
            client.Connect("smtp.gmail.com", 995, true);
            //insert password
            client.Authenticate("unibanken@gmail.com", "@9^BVqx}$E<M{VAt");
            Assert.Equal("A student has applied to "+project.Title, client.GetMessage(client.Count - 1).Subject);
        }

        [Fact]
        public async Task SendProjectDeletedNotificationAsync_Sends_Notification_To_Students()
        {
            var student = new Student{Id = 1,Name = "student1", Email = "unibanken@gmail.com"};
            var supervisor = new Supervisor{Id = "1", Name = "Supervisor1", Email = "unibanken@gmail.com", Projects = new List<Project>()};
            var project = new Project { Id = 1, Title = "Project1", Description = "This is project 1", Supervisor = supervisor, Notification = true };
            var application = new Application { Id = 1, Title = "title1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore.", Student = student, Project = project };
            var application1 = new Application { Id = 1, Title = "title2", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore.", Student = student, Project = project };
            project.Applications.Add(application);
            project.Applications.Add(application1);
            await EmailSender.SendProjectDeletedNotificationAsync(project);
            using var client = new Pop3Client();
            client.Connect("smtp.gmail.com", 995, true);
            //insert password
            client.Authenticate("unibanken@gmail.com", "@9^BVqx}$E<M{VAt");
            Assert.Equal($"Project {project.Title} has been deleted", client.GetMessage(client.Count - 1).Subject);
            Assert.Equal($"Project {project.Title} has been deleted", client.GetMessage(client.Count - 2).Subject);
        }
    }
}