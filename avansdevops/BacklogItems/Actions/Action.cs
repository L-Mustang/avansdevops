﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.BacklogItem.Actions
{
    public class Action
    {
        private IActionState _stateDone;
        private IActionState _stateTodo;
        private IActionState _state;

        private BacklogItem _backlogItem;
        private int _actionId;
        private string _actionName { get; set; }

        private int? _userId;

        public Action(int actionId, BacklogItem backlogItem, string actionName, int? userId)
        {
            _actionId = actionId;
            _backlogItem = backlogItem;
            _actionName = actionName;

            this._stateDone = new ActionStateDone(this);
            this._stateTodo = new ActionStateTodo(this);
            this._state = _stateTodo;

            if (userId != null)
            {
                this._userId = userId;
            }
        }

        public void SetState(IActionState state)
        {
            this._state = state;
        }

        public IActionState GetState()
        {
            return this._state;
        }
    }

    
}
