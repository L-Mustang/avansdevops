using avansdevops.DevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintReport
{
    public interface IBuildJobAdapter
    {
        void CreateBuildJob(Branch branch);
    }
}
