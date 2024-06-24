using System.Net;
using System.Net.Mail;

namespace Emailapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmtpClient smtpClient = new SmtpClient("mail.johnv.ca")
            {
                Port = 587,
                Credentials = new NetworkCredential("john@johnv.ca", "AskSeekKnock//"),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage();
 
            mailMessage.From = new MailAddress("john@johnv.ca");
            mailMessage.To.Add("jvandijk.mail@gmail.com");

            mailMessage.Subject = "The subject of my email";
            mailMessage.Body = "<b>This is awesome</b>";
            mailMessage.IsBodyHtml = true;

            smtpClient.Send(mailMessage);
            Console.WriteLine("Emailing Done!");
        }
    }
}
