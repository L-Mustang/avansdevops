using avansdevops.BacklogItems;
using avansdevops.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public class SprintManager : IManager
    {
        private List<IObserver<ISprint>> _listeners;

        public SprintManager()
        {
            _listeners = new List<IObserver<ISprint>>();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<ISprint>> listeners;
            private IObserver<ISprint> listener;

            public Unsubscriber(List<IObserver<ISprint>> listeners, IObserver<ISprint> listener)
            {
                this.listeners = listeners;
                this.listener = listener;
            }

            public void Dispose()
            {
                if (!(listener == null)) listeners.Remove(listener);
            }
        }
        public IDisposable Subscribe(IObserver<ISprint> listener)
        {
            if (!_listeners.Contains(listener))
                _listeners.Add(listener);

            return new Unsubscriber(_listeners, listener);
        }

        public void SprintChanged(ISprint sprint)
        {
            foreach(IObserver<ISprint> listener in _listeners)
            {
                listener.OnNext(sprint);
            }
        }

        public void SendNotificationToUser(ISprint sprint, IUser user, BacklogItem backlogItem)
        {
            foreach(SprintListener listener in _listeners)
            {
                listener.OnNext(sprint, user, backlogItem);
            }
        }

    }

}
