using avansdevops.BacklogItems;
using avansdevops.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public class ReleaseSprint : ISprint
    {
        public bool _status { get; set; }
        public List<BacklogItem> _backlogItems { get; set; }
        public List<IUser> _users { get; set; }
        public SprintManager _sprintManager { get; set; }

        public ReleaseSprint()
        {
            _status = true;
            _backlogItems = new List<BacklogItem>();
            _users = new List<IUser>();

            _sprintManager = new SprintManager();

            _sprintManager.Subscribe(new SprintListener());
        }

        public List<BacklogItem> AddBacklogItem(BacklogItem backlogItem)
        {
            backlogItem.SendNotification = new System.Action(() => SendNotification(backlogItem, typeof(ScrumMaster)));
            _backlogItems.Add(backlogItem);
            return _backlogItems;
        }

        public List<IUser> AddUser(IUser user)
        {
            _users.Add(user);
            return _users;
        }

        public void execute()
        {
            Console.WriteLine("This is to be executed from a release branch");
        }

        public List<IUser> GetAllUsers()
        {
            return _users;
        }

        public bool GetStatus()
        {
            throw new NotImplementedException();
        }

        public IUser GetUser(string fullName)
        {
            return _users.Find(x => x.FullName == fullName);
        }

        public IUser GetUser(Type type)
        {
            return _users.Find(x => x.GetType() == type);
        }

        public void RemoveBacklogItem(BacklogItem backlogItem)
        {
            _backlogItems.Remove(backlogItem);
        }

        public void RemoveUser(IUser user)
        {
            _users.Remove(user);
        }

        public void SendNotification(BacklogItem backlogItem, Type userType)
        {
            IUser user = GetUser(userType);
            _sprintManager.SendNotificationToUser(this, user, backlogItem);
        }

        public void SetStatus(bool status)
        {
            _status = status;
            _sprintManager.SprintChanged(this);
        }
    }
}
