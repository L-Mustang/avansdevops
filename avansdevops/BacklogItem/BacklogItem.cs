using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace avansdevops.BacklogItem
{
	public class BacklogItem
	{
		private IBacklogItemState _stateDone;
		private IBacklogItemState _stateTested;
		private IBacklogItemState _stateTesting;
		private IBacklogItemState _stateReadyForTesting;
		private IBacklogItemState _stateDoing;
		private IBacklogItemState _stateTodo;

		private IBacklogItemState _state;

		private int _backlogItemId { get; set; }
		private string _title { get; set; }

		private int _userId { get; set; }

		public BacklogItem(int backlogItemId, string title, int userId)
		{

			this._stateDone = new BacklogItemStateDone(this);
			this._stateTested = new BacklogItemStateTested(this);
			this._stateTesting = new BacklogItemStateTesting(this);
			this._stateReadyForTesting = new BacklogItemStateReadyForTesting(this);
			this._stateDoing = new BacklogItemStateDoing(this);
			this._stateTodo = new BacklogItemStateTodo(this);
			this._state = _stateTodo;

			this._backlogItemId = backlogItemId;
			this._title = title;
			this._userId = userId;
		}

		public void SetState(IBacklogItemState state)
		{
			this._state = state;
		}

		public IBacklogItemState GetState()
		{
			return this._state;
	
		}
		public void SetUser(int userId)
        {
			_userId = userId;
        }
	}
}
