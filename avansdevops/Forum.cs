using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public class Forum
    {
        private List<ForumThread> _threads;

        public Forum(int id, string name)
        {
            _threads = new List<ForumThread>();
        }

        public void AddThread(ForumThread thread)
        {
            if (thread != null)
            {
                _threads.Add(thread);
            }
        }
    }
}
