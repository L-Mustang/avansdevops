using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.DevOps.Testers
{
    public interface ITestingAdapter
    {
        public void Test(Branch branch);
    }
}
