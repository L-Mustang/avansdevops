using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.DevOps
{
    public class Branch
    {
        private string _name;

        public Branch(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Push()
        {
            Console.WriteLine("Pushed changes to branch " + _name);
        }

        public void Pull()
        {
            Console.WriteLine("Pulled changes from origin");
        }

        public void Commit()
        {
            Console.WriteLine("Created commit on branch {0}", _name);
        }

        public void Checkout()
        {
            Console.WriteLine("Checked out on branch {0}", _name);
        }
    }
}
