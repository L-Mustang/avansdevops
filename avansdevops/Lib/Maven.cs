using avansdevops.DevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class Maven
    {
        public Maven()
        {
        }

        public void CreateMavenBuildJob(Branch branch)
        {
            Console.WriteLine("Building Maven project...");
            Console.WriteLine("Build completed of branch {0}", branch.Name);
        }
    }
}
