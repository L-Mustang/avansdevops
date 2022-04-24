using avansdevops.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Notifications
{
    public interface INotificationAdapter
    {
        public void SendNotification(string message);
    }
}
