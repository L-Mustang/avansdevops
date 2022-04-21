using avansdevops.DevOps;
using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class MavenAdapter : IBuildJobAdapter
    {
        private Maven _instance;
        public MavenAdapter(Maven instance)
        {
            _instance = instance;
        }

        public void CreateBuildJob(Branch branch)
        {
            _instance.CreateMavenBuildJob(branch);
        }
    }
}
