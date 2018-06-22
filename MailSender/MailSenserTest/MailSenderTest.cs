using Moq;
using NLog;
using MailSender;
using FileSearcher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Configuration;

namespace MailTest
{
    [TestClass]
    public class MailSendTest
    {
        string[] validArray = new string[] { "test", "test2", "test3" };

        [TestMethod]
        public void GetFiles_With_Valid_Queue()
        {
            var moq = new Mock<ILogger>();
            var sender = new MailSend(moq.Object);
            var queue = new Queue<string>(validArray);
            sender.GetFiles(queue);
            moq.Verify(s => s.Error(It.IsAny<string>()), () => Times.Exactly(3));
            Assert.AreEqual(0, queue.Count);
        }

        [TestMethod]
        public void GetFiles_With_Null_Reference()
        {
            var moq = new Mock<ILogger>();
            var sender = new MailSend(moq.Object);
            sender.GetFiles(null);
            moq.Verify(s => s.Error(It.IsAny<string>()), () => Times.Exactly(1));
        }

        [TestMethod]
        public void GetFiles_With_Empty_Queue()
        {
            var moq = new Mock<ILogger>();
            var sender = new MailSend(moq.Object);
            var queue = new Queue<string>();
            sender.GetFiles(queue);
            moq.Verify(s => s.Info(It.IsAny<string>()), () => Times.Exactly(0));
            moq.Verify(s => s.Error(It.IsAny<string>()), () => Times.Exactly(0));
        }

    [TestClass]
    public class FileSearcherTest
        {
            string[] invalidArray = new string[] { "test", "test2", "test3" };
            [TestMethod]
            public void SearchFiles_With_Invalid_Path()
            {
                var moq = new Mock<IPath>();
                var moq1 = new Mock<ILogger>();
                var searcher = new FileSearch(moq.Object,moq1.Object);
                var testSearch = searcher.SearchFiles("A:\test");
                moq1.Verify(s => s.Error(It.IsAny<string>()), () => Times.Exactly(1));
                Assert.AreEqual(false, testSearch);
            }

            [TestMethod]
            public void SearchFiles_With_Valid_Path()
            {
                var moq = new Mock<IPath>();
                var moq1 = new Mock<ILogger>();
                var searcher = new FileSearch(moq.Object, moq1.Object);
                var testSearch = searcher.SearchFiles(ConfigurationManager.AppSettings["pathToDirectory"]);
                Assert.AreEqual(true, testSearch);
            }

            [TestMethod]
            public void DeleteFiles_With_Null_Reference()
            {
                var moq = new Mock<IPath>();
                var moq1 = new Mock<ILogger>();
                var searcher = new FileSearch(moq.Object, moq1.Object);
                searcher.DeleteFiles(null);
                moq1.Verify(s => s.Error(It.IsAny<string>()), () => Times.Exactly(1));
            }

            [TestMethod]
            public void DeleteFiles_With_Empty_Queue()
            {
                var moq = new Mock<IPath>();
                var moq1 = new Mock<ILogger>();
                var searcher = new FileSearch(moq.Object, moq1.Object);
                searcher.DeleteFiles(new Queue<string>());
                moq1.Verify(s => s.Error(It.IsAny<string>()), () => Times.Exactly(0));
                moq1.Verify(s => s.Info(It.IsAny<string>()), () => Times.Exactly(0));
            }

            [TestMethod]
            public void DeleteFiles_With_Valid_Queue()
            {
                var moq = new Mock<IPath>();
                var moq1 = new Mock<ILogger>();
                var searcher = new FileSearch(moq.Object, moq1.Object);
                searcher.DeleteFiles(new Queue<string>(invalidArray));
                moq1.Verify(s => s.Info(It.IsAny<string>()), () => Times.Exactly(3));
            }
        }
    }
}
