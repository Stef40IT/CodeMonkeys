using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Monkey.Core.Services.EmailServices
{
    public class EmailService : IEmailService
    {
        private readonly string _smtpServer = "smtp.gmail.com";
        private readonly int _smtpPort = 587;
        private  string _smtpUser = "boardgamesrentalsinc@gmail.com";
        private string _smtpPass = "rbwy tbxd miws uptl"; 

        public async Task SendEmailAsync(string fromName, string fromEmail, string subject, string message)
        {
            var mailMessage = new MimeMessage();
            if(fromEmail == "danailovvpetar@gmail.com")
            {
                _smtpUser = "danailovvpetar@gmail.com";
                _smtpPass = "uwli ybwd uonu wvgp";
            }
            mailMessage.From.Add(new MailboxAddress(fromName, fromEmail));
            mailMessage.To.Add(new MailboxAddress("Board GamesInc", "boardgamesrentalsinc@gmail.com"));
            mailMessage.Subject = subject;
            mailMessage.Body = new TextPart("plain")
            {
                Text = message
            };

            using (var smtpClient = new MailKit.Net.Smtp.SmtpClient())
            {
                await smtpClient.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
                await smtpClient.AuthenticateAsync(_smtpUser, _smtpPass);
                await smtpClient.SendAsync(mailMessage);
                await smtpClient.DisconnectAsync(true);
            }
        }
    }
}

