using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public class SprintManager : IManager
    {
        private List<IObserver<Sprint>> _listeners;

        public SprintManager()
        {
            _listeners = new List<IObserver<Sprint>>();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Sprint>> listeners;
            private IObserver<Sprint> listener;

            public Unsubscriber(List<IObserver<Sprint>> listeners, IObserver<Sprint> listener)
            {
                this.listeners = listeners;
                this.listener = listener;
            }

            public void Dispose()
            {
                if (!(listener == null)) listeners.Remove(listener);
            }
        }
        public IDisposable Subscribe(IObserver<Sprint> listener)
        {
            if (!_listeners.Contains(listener))
                _listeners.Add(listener);

            return new Unsubscriber(_listeners, listener);
        }

        public void SprintChanged(Sprint sprint)
        {
            foreach(IObserver<Sprint> listener in _listeners)
            {
                listener.OnNext(sprint);
            }
        }

        public void Sprint()
        {
            foreach (IObserver<Sprint> listener in _listeners)
                listener.OnCompleted();

            _listeners.Clear();
        }
    }

}
