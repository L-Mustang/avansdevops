using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.BacklogItems;
using avansdevops.Notifications;

namespace avansdevops.BacklogItems;

public class BacklogItemListener : IObserver<BacklogItem>
{
    private IDisposable? _unsubscriber;
    public string? _message;

    public virtual void Subscribe(IObservable<BacklogItem> manager)
    {
        _unsubscriber = manager.Subscribe(this);
    }

    public virtual void Unsubscribe()
    {
        _unsubscriber?.Dispose();
    }

    public virtual void OnCompleted()
    {
        Console.WriteLine("BacklogItem listener disconnected.");
    }

    public virtual void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public virtual void OnNext(BacklogItem backlogItem)
    {
        _message = $"BacklogItem '{backlogItem.GetTitle()}' has been set to {backlogItem.GetState().ToString().Substring(41)}";
        INotificationAdapter notificationServiceSmtp = new SmtpAdapter(new Lib.SMTP());
        INotificationAdapter notificationServiceSlack = new SlackAdapter(new Lib.SlackAPI());

        notificationServiceSlack.SendNotification(_message);
        notificationServiceSmtp.SendNotification(_message);
    }
}
