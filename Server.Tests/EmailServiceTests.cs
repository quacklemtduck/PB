using System.Threading.Tasks;
using MailKit.Net.Pop3;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using System;


namespace Server.Tests
{
    public class EmailServiceTests
    {
        [Fact]
        public async Task Using_SendMailAsync_sends_mail()
        {
            var rand = new Random();
            var mailsubject = "mailsubjecttest"+rand.Next(1000);
            await EmailService .SendMailAsync("unibanken@gmail.com",mailsubject,"this is the body of the email");
            using var client = new Pop3Client();
            client.Connect("smtp.gmail.com", 995, true);
            //insert password
            client.Authenticate("unibanken@gmail.com", "");
            Assert.Equal(mailsubject, client.GetMessage(client.Count - 1).Subject);
        }
    }
}