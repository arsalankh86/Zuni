using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Zuni.Service
{
    public class CommunicationRepository
    {
        public CommunicationRepository()
        { }
        public bool SendEmail(string fromemail, string toemail, string subject, int emailsendingcode,
            string emailMessage, string username, string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(fromemail);
                mail.To.Add(toemail);
                mail.Subject = subject;
                mail.Body = emailMessage;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public bool SendMessage()
        {
            //http://api.bizsms.pk
            //http://api.bizsms.pk/api-send-branded-sms.aspx?username={userName}&pass={password}&text={messageText}&masking={masking}&destinationnum={destinationNumber}&language=English

            return false;
        }
    }
}
