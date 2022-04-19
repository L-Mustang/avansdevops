using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItems.Actions
{
    internal class ActionStateTodo : IActionState
    {
        private Action _action;

        public ActionStateTodo(Action action)
        {
            _action = action;
        }
    }
}
