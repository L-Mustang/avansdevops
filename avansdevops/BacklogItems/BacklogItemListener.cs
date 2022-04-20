using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.BacklogItems;

namespace avansdevops.BacklogItems;

public class BacklogItemListener : IObserver<BacklogItem>
{
    private IDisposable? unsubscriber;
    public string? message;

    public virtual void Subscribe(IObservable<BacklogItem> manager)
    {
        unsubscriber = manager.Subscribe(this);
    }

    public virtual void Unsubscribe()
    {
        unsubscriber?.Dispose();
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
        this.message = $"Your item has been set to {backlogItem.GetState()}";
    }
}
