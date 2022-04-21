using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.Notifications;

namespace avansdevops
{
    public class SprintListener : IObserver<Sprint>
    {
        private IDisposable? _unsubscriber;
        public string? _message;

        public virtual void Subscribe(IObservable<Sprint> manager)
        {
            _unsubscriber = manager.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber?.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Sprint listener disconnected.");
        }

        public virtual void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public virtual void OnNext(Sprint sprint)
        {
            _message = $"Your sprint has been set to {sprint.GetStatus}";
            INotificationAdapter notificationServiceSmtp = new SmtpAdapter(new Lib.SMTP());
            INotificationAdapter notificationServiceSlack = new SlackAdapter(new Lib.SlackAPI());

            notificationServiceSlack.SendNotification(_message);
            notificationServiceSmtp.SendNotification(_message);

        }
    }
}
