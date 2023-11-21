using Prohix.Application.Services.Commons.Publics.EmailService.Models;
using Prohix.Core.Entities.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Application.Services.Commons.Publics.EmailService
{
    public class EmailService : IEmailService
    {
        public async Task<Task> SendEmail(EmailServiceInputModel inputModel)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.Host = "mail.prohix.com";
            //client.Port = 587;
            //client.Host = "smtp.gmail.com";
            client.EnableSsl = false;
            client.Timeout = 1000000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            //در خط بعدی ایمیل  خود و پسورد ایمیل خود  را جایگزین کنید
            client.Credentials = new NetworkCredential("noreply@prohix.com", "prohix@1400");
            MailMessage message = new MailMessage("noreply@prohix.com", inputModel.Email, inputModel.Subject, inputModel.Body);

            //client.Credentials = new NetworkCredential("prohixco@gmail.com", "prohix@1400");
            //MailMessage message = new MailMessage("prohixco@gmail.com", UserEmail, Subject, Body);

            //message.From = new MailAddress("noreply@prohix.com");
            //  ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(RemoteServerCertificateValidationCallback);

            //         ServicePointManager.ServerCertificateValidationCallback =
            //delegate (object sender, X509Certificate certificate, X509Chain chain,
            //    SslPolicyErrors sslPolicyErrors)
            //{ return true; };


            message.IsBodyHtml = true;
            message.BodyEncoding = UTF8Encoding.UTF8;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            client.Send(message);
            return Task.CompletedTask;
        }
    }
}
