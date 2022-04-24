using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using avansdevops.User;

namespace avansdevops.BacklogItems.Actions
{
    public class Action
    {
        private IActionState _stateDone;
        private IActionState _stateTodo;
        private IActionState _state;

        private int _actionId;
        private string _actionName { get; set; }

        private IUser? _user;

        public Action(int actionId, string actionName, IUser? user)
        {
            _actionId = actionId;
            _actionName = actionName;

            this._stateDone = new ActionStateDone(this);
            this._stateTodo = new ActionStateTodo(this);
            this._state = _stateTodo;

            _user = user;
        }

        public void SetState(IActionState state)
        {
            this._state = state;
        }

        public IActionState GetState()
        {
            return this._state;
        }

        public IActionState GetStateDone()
        {
            return _stateDone;
        }

        public IActionState GetStateTodo()
        {
            return _stateTodo;
        }

    }    
}
