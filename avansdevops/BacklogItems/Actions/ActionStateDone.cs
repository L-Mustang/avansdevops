using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItems.Actions
{
    public class ActionStateDone : IActionState
    {
        private Action _action;

        public ActionStateDone(Action action)
        {
            _action = action;  
        }
    }
}
