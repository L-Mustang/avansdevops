    using avansdevops.BacklogItems.Actions;

namespace avansdevops.BacklogItems
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
        private List<Actions.Action>? _actions;

        public BacklogItemManager _backlogItemManager;

        private int _backlogItemId { get; set; }
        private string _title { get; set; }

        private int? _userId { get; set; }

        public BacklogItem(int backlogItemId, string title, int? userId)
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

            this._backlogItemManager = new BacklogItemManager();

            _actions = new List<Actions.Action>();

            if (userId != null)
            {
                _userId = userId;
            }

            _backlogItemManager.Subscribe(new BacklogItemListener());
        }

        public void SetState(IBacklogItemState state)
        {
            _state = state;
            _backlogItemManager.BacklogItemStateChanged(this);
        }

        public IBacklogItemState GetState()
        {
            return this._state;
        }

        public void AddAction(Actions.Action action)
        {
            if(action != null)
            {
                _actions.Add(action);
            }
        }

        public void RemoveAction(Actions.Action action)
        {
            try
            {
                if (action != null)
                {
                    _actions.Remove(action);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }            
        }

        public List<Actions.Action> GetActions()
        {
            return _actions;
        }

        public string GetTitle()
        {
            return _title;
        }

        public int GetId()
        {
            return _backlogItemId;
        }

        public IBacklogItemState GetStateDone()
        {
            return _stateDone;
        }

        public IBacklogItemState GetStateDoing()
        {
            return _stateDoing;
        }

        public IBacklogItemState GetStateReadyForTesting()
        {
            return _stateReadyForTesting;
        }

        public IBacklogItemState GetStateTesting()
        {
            return _stateTesting;
        }

        public IBacklogItemState GetStateTested()
        {
            return _stateTested;
        }

        public IBacklogItemState GetStateTodo()
        {
            return _stateTodo;
        }
    }
}
