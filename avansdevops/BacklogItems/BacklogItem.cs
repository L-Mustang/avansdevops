using Action = avansdevops.BacklogItems.Actions.Action;
using System;
using avansdevops.BacklogItems.Actions;
using avansdevops.User;

namespace avansdevops.BacklogItems
{
    public class BacklogItem
    {
       

        private BacklogItemStatus _status;
        private List<Action>? _actions;

        public System.Action SendNotification;
        public BacklogItemManager _backlogItemManager;

        private int _backlogItemId;
        private string _title;

        private IUser? _user;

        public BacklogItem(int backlogItemId, string title, IUser? user)
        {
            this._status = BacklogItemStatus.Todo;

            this._backlogItemId = backlogItemId;
            this._title = title;

            this._backlogItemManager = new BacklogItemManager();

            _actions = new List<Action>();

            _user = user;

            _backlogItemManager.Subscribe(new BacklogItemListener());
        }

        public IUser user
        {
            get { return _user;  }
            set { if (value.GetType() == typeof(Developer))
                    _user = value;
                 }
        }

        public void SetState(BacklogItemStatus state)
        {

            _status = state;
            _backlogItemManager.BacklogItemStateChanged(this);

            if (state == BacklogItemStatus.Todo) {
                if(SendNotification != null)
                {
                    this.SendNotification();
                }                
                _backlogItemManager.BacklogItemStateChangedTodo(this);
            } 

        }

        public BacklogItemStatus GetState()
        {
            return this._status;
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

        public List<Action> GetActions()
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
    }
}
