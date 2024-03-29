﻿using avansdevops.Lib;
using avansdevops.SprintReport;
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

        public void InstallPackage(string packageUrl, Branch branch)
        {
            Console.WriteLine("Downloading package from: {0}", packageUrl);
        }

        public void Deploy(Branch branch)
        {
            Console.WriteLine("Deployed");
        }

        public void Test(Branch branch, ITestingAdapter testingAdapter)
        {
            testingAdapter.Test(branch);
        }

        public void Build(Branch branch, IBuildJobAdapter buildJobAdapter)
        {
            buildJobAdapter.CreateBuildJob(branch);
        }

        public void Analyse(Branch branch)
        {
            Console.WriteLine("Analysing...");
            Console.WriteLine("Analysis completed on branch {0}", branch.Name);
        }
    }

}
