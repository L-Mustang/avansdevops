using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.SprintStrategy
{
    public class SprintStrategyFeedback : ISprintStrategy
    {
        public void execute()
        {
            Console.WriteLine("Do this for feedback strategy");
        }
    }
}
