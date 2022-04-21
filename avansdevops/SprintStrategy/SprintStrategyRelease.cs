using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintStrategy
{
    public class SprintStrategyRelease : ISprintStrategy
    {
        public void execute()
        {
            Console.WriteLine("Do this for release strategy");
        }
    }
}
