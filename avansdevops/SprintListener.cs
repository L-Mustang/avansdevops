using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public class SprintListener : IObserver<Sprint>
    {
        private IDisposable? unsubscriber;
        public string? message;

        public virtual void Subscribe(IObservable<Sprint> manager)
        {
            unsubscriber = manager.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber?.Dispose();
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
            this.message = $"Your sprint has been set to {sprint.GetStatus}";
        }
    }
}
