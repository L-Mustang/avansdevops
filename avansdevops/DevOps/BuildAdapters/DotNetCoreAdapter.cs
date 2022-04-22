using avansdevops.DevOps;
using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class DotNetCoreAdapter : IBuildJobAdapter
    {
        private DotNetCore _instance;
        public DotNetCoreAdapter(DotNetCore instance)
        {
            _instance = instance;
        }

        public void CreateBuildJob(Branch branch)
        {
            _instance.CreateDotNetCoreBuildJob(branch);
        }
    }
}
