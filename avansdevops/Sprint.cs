using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avansdevops.User;
using avansdevops.BacklogItems;
using avansdevops.SprintStrategy;

namespace avansdevops
{
    public class Sprint
    {
        private List<BacklogItem> _backlogItems;
        private List<IUser> _users;
        private bool _active;


        public SprintManager _sprintManager;
        private ISprintStrategy _strategy;

        public Sprint(ISprintStrategy strategy)
        {
            _active = true;
            _backlogItems = new List<BacklogItem>();
            _users = new List<IUser>();

            _strategy = strategy;
            _sprintManager = new SprintManager();
        }

        public List<BacklogItem> GetAllBacklogItems()
        {
            return _backlogItems;
        }

        public List<BacklogItem> AddBacklogItem(BacklogItem backlogItem)
        {
            _backlogItems.Add(backlogItem);
            return _backlogItems;
        }

        public void RemoveBacklogItem(BacklogItem backlogItem)
        {
            _backlogItems.Remove(backlogItem);
        }

        public void SetBacklogItemState(BacklogItem item, IBacklogItemState state)
        {
            item.SetState(state);
        }

        public List<IUser> AddUser(IUser user)
        {
            _users.Add(user);
            return _users;
        }

        public void RemoveUser(IUser user)
        {
            _users.Remove(user);
        }

        public List<IUser> GetAllUsers()
        {
            return _users;
        }

        public IUser GetUser(string fullName) 
        {
            return _users.Find(x => x.FullName == fullName);
        }

        public void FinishSprint()
        {
            _active = false;
        }

        public ISprintStrategy GetStrategy()
        {
            return _strategy;
        }

        public bool GetStatus()
        {
            return _active;
        }

        public void setStatus(bool status)
        {
            _active = status;
            _sprintManager.SprintChanged(this);            
        }
    }
}
