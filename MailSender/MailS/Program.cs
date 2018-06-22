using NLog;
using MailSender;
using FileSearcher;
using System.Configuration;
using System.Threading;

namespace MailS
{
    class Program
    {
        static void Main(string[] args)
        {
            var sender = new MailSend(LogManager.GetCurrentClassLogger());
            var searcher = new FileSearch(sender, LogManager.GetCurrentClassLogger());
            var path = ConfigurationManager.AppSettings["pathToDirectory"];
            while (searcher.SearchFiles(path))
            {
                    searcher.DeleteFiles(sender.SuccessfullySentFiles);
                    Thread.Sleep(10000);
            }
        }
    }
}
