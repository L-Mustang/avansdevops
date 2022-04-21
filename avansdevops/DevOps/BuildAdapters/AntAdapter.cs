using avansdevops.DevOps;
using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class AntAdapter : IBuildJobAdapter
    {
        private Ant _instance;
        public AntAdapter(Ant instance)
        {
            _instance = instance;
        }

        public void CreateBuildJob(Branch branch)
        {
            _instance.CreateAntBuildJob(branch);
        }
    }
}
