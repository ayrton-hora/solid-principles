using System.Net.Mail;

namespace SOLID_Principles.Principles.SRP.Violation
{
    internal class Request
    {
        public long Quantity { get; set; }

        public DateTime Data { get; set; }

        public void SendRequestEmail(MailMessage mailMessage)
        {
            try
            {
                // To do
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"..\Logs\Errorlog.txt", ex.ToString());
            }
        }

        public void AddRequest()
        {
            try
            {
                MailMessage mailMessage = new("EmailFrom", "EmailTo", "EmailSubject", "EmailBody");

                SendRequestEmail(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"..\Logs\Errorlog.txt", ex.ToString());
            }
        }

        public void DeleteRequest()
        {
            try
            {
                // To do
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"..\Logs\Errorlog.txt", ex.ToString());
            }
        }
    }
}
