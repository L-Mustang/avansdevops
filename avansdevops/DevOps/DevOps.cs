using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.DevOps.Testers;

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

        public void Deploy(Branch branch)
        {
            Console.WriteLine("Deployed");
        }

        public void Test(Branch branch, string tester)
        {
            ITestingAdapter? testingAdapter = null;
            switch (tester)
            {
                case "NUnit":
                    testingAdapter = new NUnitAdapter(new Lib.NUnit());
                    Console.WriteLine("Finished all tests");
                    break;

                case "Selenium":
                    testingAdapter = new SeleniumAdapter(new Lib.Selenium());
                    Console.WriteLine("Finished all tests");
                    break;

                default:
                    Console.WriteLine("Platform not found");
                    break;
            }
            if (testingAdapter != null)
            {
                testingAdapter.Test(branch);
            }
        }

        public void Build(Branch branch)
        {
            Console.WriteLine("Building...");
            Console.WriteLine("Build completed");

        }

        public void Analyse(Branch branch)
        {
            Console.WriteLine("Analysing...");
            Console.WriteLine("Analysis completed. ");
        }
    }

}
