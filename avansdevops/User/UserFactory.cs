using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avansdevops.User
{
    public abstract class UserFactory
    {
        public abstract IUser CreateUser();
    }
}
