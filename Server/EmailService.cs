using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Server
{
    public class EmailService
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
            await client.AuthenticateAsync("unibanken@gmail.com","");
            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}