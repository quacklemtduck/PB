namespace PB.Infrastructure
{
    public class EmailSender
    {   
        public static async Task SendMailAsync(string to, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Unibanken", "unibanken@gmail.com"));
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;
            message.Body = new TextPart(MimeKit.Text.TextFormat.Plain) {Text = body};

            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 465, true);
            //insert password
            await client.AuthenticateAsync("unibanken@gmail.com","@9^BVqx}$E<M{VAt");
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }

        public static async Task SendNewApplicationNotificationAsync(Application a)
        {
            var p = a.Project;
            if (!p.Notification) return;
            var supervisor = p.Supervisor;
            var s = a.Student;
            await SendMailAsync(supervisor.Email,"A student has applied to "+p.Title,$"{s?.Name} has applied to {p.Title} {Environment.NewLine}The applican is titled: {a.Title} {Environment.NewLine}A brief part of the application description is: {a.Description?.Substring(0,100)}");
        }

        public static async Task SendProjectDeletedNotificationAsync(Project project)
        {
            foreach (var application in project.Applications)
            {
                var student = application.Student;
                await SendMailAsync(student.Email,$"Project {project.Title} has been deleted",$"The project {project.Title} you have applied to has been deleted {Environment.NewLine}You can find other projects to apply to at our website");
            }
        }
    }
}