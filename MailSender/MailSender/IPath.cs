using System.Collections.Generic;

namespace MailSender
{
    public interface IPath
    {
        void GetFiles (Queue<string> path);
    }
}
