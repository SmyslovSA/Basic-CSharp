using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using NLog;
using System.Configuration;

namespace MailSender
{
    public class MailSend : IPath
    {
        private readonly string mailSender = ConfigurationManager.AppSettings["mailSender"];
        private readonly string password = ConfigurationManager.AppSettings["password"];
        private readonly string mailReceiver = ConfigurationManager.AppSettings["mailReceiver"];
        private readonly string messageText = ConfigurationManager.AppSettings["messageText"];
        private readonly ILogger logger;

        private Queue<string> _successfullySentFiles = new Queue<string>();
        public Queue<string> SuccessfullySentFiles => _successfullySentFiles;

        public MailSend(ILogger logger)
        {
            this.logger = logger;
        }       

        private bool SendEmail(string queueElement)
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(mailSender, password);
                using (var message = new MailMessage(mailSender, mailReceiver, string.Empty, messageText))
                {
                    try
                    {
                        var attach = new Attachment(queueElement);
                        message.Attachments.Add(attach);
                        client.Send(message);                       
                    }
                    catch (Exception ex)
                    {
                        logger.Error($"{ex.Message}");
                        return false;
                    }
                }
            }
            return true;
        }

        /*[Tests]
         GetFiles_With_Valid_Queue()
         GetFiles_With_Null_Reference()
         GetFiles_With_Empty_Queue()
        */
        public void GetFiles(Queue<string> queue)
        {
            if (queue == null)
            {
                logger.Error("There are no files to send");
                return;
            }
            while (queue.Count > 0)
            {
                if (SendEmail(queue.Peek()))
                {
                    logger.Info($"File was sended to e-mail {mailReceiver}");
                    SuccessfullySentFiles.Enqueue(queue.Peek());
                }
                queue.Dequeue();
            }
        }
    }
}
