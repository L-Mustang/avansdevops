using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.BacklogItems;

namespace avansdevops.BacklogItems;

public class BacklogItemManager : IManager
{
    private List<IObserver<BacklogItem>> _listeners;

    public BacklogItemManager()
    {
        _listeners = new List<IObserver<BacklogItem>>();
    }

    private class Unsubscriber : IDisposable
    {
        private List<IObserver<BacklogItem>> listeners;
        private IObserver<BacklogItem> listener;

        public Unsubscriber(List<IObserver<BacklogItem>> listeners, IObserver<BacklogItem> listener)
        {
            this.listeners = listeners;
            this.listener = listener;
        }

        public void Dispose()
        {
            if (!(listener == null)) listeners.Remove(listener);
        }
    }
    public IDisposable Subscribe(IObserver<BacklogItem> listener)
    {
        if (!_listeners.Contains(listener))
            _listeners.Add(listener);

        return new Unsubscriber(_listeners, listener);
    }

    public void BacklogItemStateChanged(BacklogItem backlogItem)
    {
        foreach (IObserver<BacklogItem> listener in _listeners)
        {
            listener.OnNext(backlogItem);
        }
    }

    public void Sprint()
    {
        foreach (IObserver<Sprint> listener in _listeners)
            listener.OnCompleted();

        _listeners.Clear();
    }
}
