using System.Net.Mail;

namespace SOLID_Principles.Principles.SRP.Cohesive
{
    internal class Request
    {
        public long Quantity { get; set; }

        public DateTime Data { get; set; }
                
        private readonly ILogger logger;

        private readonly SendEmail sendEmail;

        public Request()
        {
            logger = new Logger();
            sendEmail = new SendEmail();
        }

        public void AddRequest()
        {
            try
            {
                sendEmail.EmailFrom = "EmailFrom";
                sendEmail.EmailTo = "EmailTo";
                sendEmail.EmailSubject = "EmailSubject";
                sendEmail.EmailBody = "EmailBody";

                sendEmail.Send();

                logger.Info("Request added");
            }
            catch (Exception ex)
            {
                logger.Info("Error on add request: " + ex.Message);
            }
        }

        public void DeleteRequest()
        {
            try
            {
                // To do
                logger.Info("Request deleted");
            }
            catch (Exception ex)
            {
                logger.Info("Error on delete request: " + ex.Message);
            }
        }
    }
}
