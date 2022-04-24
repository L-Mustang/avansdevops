using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.DevOps;

namespace avansdevops
{
    public class Project
    {
        private ProductBacklog _productBacklog { get; set; }
        private Forum _forum { get ; set; }
        private ISprint _sprint;
        private Repository _repo { get; set; }

        public Project()
        {
            _productBacklog = new ProductBacklog();
            _forum = new Forum();
        }

        public void AddSprint(ISprint sprint)
        {
            _sprint = new FeedbackSprint();
        }

        public void AddRepository(string name)
        {
            _repo = new Repository(name);
        }

        public Repository GetRepository()
        {
            return _repo;
        }

        public ISprint GetSprint()
        {
            return _sprint;
        }
    }
}
