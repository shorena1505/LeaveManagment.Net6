using System.Net.Mail;
using System.Threading.Tasks;
using LeaveManagment.Web.Configurations;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

namespace LeaveManagment.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage()
            {
                From = new MailAddress(_emailSettings.SenderAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(_emailSettings.Host, _emailSettings.Port)
            {
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(_emailSettings.Email, _emailSettings.Password),
                EnableSsl = true,
            };

            client.Send(message);
            return Task.CompletedTask;
        }
    }
}
