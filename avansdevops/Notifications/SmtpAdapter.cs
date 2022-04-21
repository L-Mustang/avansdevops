using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.Lib;

namespace avansdevops.Notifications
{
    public class SmtpAdapter : INotificationAdapter
    {
        private SMTP _instance;

        public SmtpAdapter(SMTP instance) 
        {
            _instance = instance;
        }

        public void SendNotification(string message)
        {
            _instance.SendSmtpNotification("Smtp: " + message);
        }
    }
}
