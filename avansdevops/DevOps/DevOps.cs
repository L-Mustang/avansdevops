using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.DevOps
{
    public class DevOps
    {
        public DevOps()
        {

        }

        public void InstallPackage(string packageUrl)
        {
            Console.WriteLine("Downloading package from: {0}", packageUrl);
        }

        public void Deploy()
        {
            Console.WriteLine("Deployed");
        }

        public void Test()
        {
            Console.WriteLine("Testing..");
            Console.WriteLine("Finished all tests");
        }

        public void Build()
        {
            Console.WriteLine("Building...");
            Console.WriteLine("Build completed");

        }

        public void Analyse()
        {
            Console.WriteLine("Analysing...");
            Console.WriteLine("Analysis completed. ")
        }
    }

}
