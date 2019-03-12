using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Clases
{
    public class UserModel
    {
        UserDAO userDao = new UserDAO();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

    }
}
