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
        public string FullName
        {
            get { return _name + " " + _surname; }
        }

    }
}
