using avansdevops.DevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class DotNet
    {
        public DotNet()
        {
        }

        public void CreateDotNetBuildJob(Branch branch)
        {
            Console.WriteLine("Building DotNet project...");
            Console.WriteLine("Build completed of branch {0}", branch.Name);
        }
    }
}
