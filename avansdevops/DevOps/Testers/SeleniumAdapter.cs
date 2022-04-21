using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.Lib;

namespace avansdevops.DevOps.Testers
{
    public class SeleniumAdapter : ITestingAdapter
    {
        private Selenium _instance;

        public SeleniumAdapter(Selenium instance)
        {
            _instance = instance;
        }

        public void Test(Branch branch)
        {
            _instance.TestSelenium(branch);
        }
    }
}
