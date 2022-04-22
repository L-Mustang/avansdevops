using avansdevops.DevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class Ant
    {
        public Ant()
        {
        }

        public void CreateAntBuildJob(Branch branch)
        {
            Console.WriteLine("Building Ant project...");
            Console.WriteLine("Build completed of branch {0}", branch.Name);
        }
    }
}
