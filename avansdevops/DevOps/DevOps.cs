using avansdevops.Lib;
using avansdevops.SprintReport;
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

        public void InstallPackage(string packageUrl, Branch branch)
        {
            Console.WriteLine("Downloading package from: {0}", packageUrl);
        }

        public void Deploy(Branch branch)
        {
            Console.WriteLine("Deployed");
        }

        public void Test(Branch branch)
        {
            Console.WriteLine("Testing..");
            Console.WriteLine("Finished all tests");
        }

        public void Build(Branch branch, BuildJobType buildJobType)
        {
            IBuildJobAdapter buildJobAdapter;
            switch (buildJobType)
            {
                case BuildJobType.DotNet:
                    buildJobAdapter = new DotNetAdapter(new DotNet());
                    break;
                case BuildJobType.DotNetCore:
                    buildJobAdapter = new DotNetCoreAdapter(new DotNetCore());
                    break;
                case BuildJobType.Ant:
                    buildJobAdapter = new AntAdapter(new Ant());
                    break;
                case BuildJobType.Jenkins:
                    buildJobAdapter = new JenkinsAdapter(new Jenkins());
                    break;
                case BuildJobType.Maven:
                    buildJobAdapter = new MavenAdapter(new Maven());
                    break;
                default:
                    return;
            }
            buildJobAdapter.CreateBuildJob(branch);
            return;
        }

        public void Analyse(Branch branch)
        {
            Console.WriteLine("Analysing...");
            Console.WriteLine("Analysis completed. ")
        }
    }

}
