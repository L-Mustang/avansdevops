using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItem.Actions
{
    internal class ActionStateDone : IActionState
    {
        private Action _action;

        public ActionStateDone(Action action)
        {
            _action = action;  
        }
    }
}
