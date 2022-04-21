using avansdevops.DevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.Lib
{
    public class Jenkins
    {
        public Jenkins()
        {
        }

        public void CreateJenkinsBuildJob(Branch branch)
        {
            Console.WriteLine("Building Jenkins project...");
            Console.WriteLine("Build completed of branch {0}", branch.Name);
        }
    }
}
