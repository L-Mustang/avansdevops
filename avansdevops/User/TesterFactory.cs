using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.User
{
    public class TesterFactory : UserFactory
    {
        private string _name;
        private string _surname;
        private string _email;

        public TesterFactory(string name, string surname, string email)
        {
            _name = name;
            _surname = surname;
            _email = email;
        }
        public override IUser CreateUser()
        {
            return new Tester(_name, _surname, _email);
        }
    }
}
