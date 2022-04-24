using avansdevops.BacklogItems;
using avansdevops.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops
{
    public interface ISprint
    {
        bool _status { get; set; }
        List<BacklogItem> _backlogItems { get; set; }
        List<IUser> _users { get; set; }
        SprintManager _sprintManager { get; set; }
        public void SetStatus(bool status);
        public bool GetStatus();
        public List<BacklogItem> AddBacklogItem(BacklogItem backlogItem);
        public void RemoveBacklogItem(BacklogItem backlogItem);
        public List<IUser> AddUser(IUser user);
        public void RemoveUser(IUser user);
        public List<IUser> GetAllUsers();
        public IUser GetUser(string fullName);
        public IUser GetUser(Type type);
        public void SendNotification(BacklogItem backlogItem, Type userType);
        public void execute();
    }
}
