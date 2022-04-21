using avansdevops.DevOps;
using avansdevops.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public class JenkinsAdapter : IBuildJobAdapter
    {
        private Jenkins _instance;
        public JenkinsAdapter(Jenkins instance)
        {
            _instance = instance;
        }

        public void CreateBuildJob(Branch branch)
        {
            _instance.CreateJenkinsBuildJob(branch);
        }
    }
}
