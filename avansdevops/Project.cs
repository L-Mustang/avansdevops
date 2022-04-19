using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public class Project
    {
        private ProductBacklog _productBacklog;
        private Forum _forum;

        public Project()
        {
            _productBacklog = new ProductBacklog();
            _forum = new Forum();
        }
    }
}
