using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.Lib;
using avansdevops.User;

namespace avansdevops.Notifications
{
    public class SlackAdapter : INotificationAdapter
    {
        private SlackAPI _instance;

        public SlackAdapter(SlackAPI instance)
        {
            _instance = instance;
        }

        public void SendNotification(string message)
        {
            _instance.SendSlackNotification("Slack: " + message);
        }
    }
}
