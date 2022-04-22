using avansdevops.DevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class DotNetCore
    {
        public DotNetCore()
        {
        }

        public void CreateDotNetCoreBuildJob(Branch branch)
        {
            Console.WriteLine("Building DotNetCore project...");
            Console.WriteLine("Build completed of branch {0}", branch.Name);
        }
    }
}
