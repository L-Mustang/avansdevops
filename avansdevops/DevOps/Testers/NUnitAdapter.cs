using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.Lib;

namespace avansdevops.DevOps.Testers
{
    public class NUnitAdapter : ITestingAdapter
    {
        private NUnit _instance;

        public NUnitAdapter(NUnit instance)
        {
            _instance = instance;
        }

        public void Test(Branch branch)
        {
            _instance.TestNUnit(branch);
        }
    }
}
