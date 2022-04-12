using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.User
{
    public class ScrumMaster : IUser
    {
        private string _name;
        private string _surname;
        private string _email;
        public ScrumMaster(string name, string surname, string email)
        {
            _name = name;
            _surname = surname;
            _email = email;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string FullName
        {
            get { return _name + " " + _surname; }
        }

    }
}
