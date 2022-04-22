using avansdevops.DevOps;
using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class DotNetAdapter : IBuildJobAdapter
    {
        private DotNet _instance;
        public DotNetAdapter(DotNet instance)
        {
            _instance = instance;
        }

        public void CreateBuildJob(Branch branch)
        {
            _instance.CreateDotNetBuildJob(branch);
        }
    }
}
