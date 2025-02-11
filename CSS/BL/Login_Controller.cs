using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSS.BL
{
    static class Login_Controller
    {
        static Civil_statusEntities1 Civ = new Civil_statusEntities1();

        static public Login Search_For_Manager_or_Employee(string user_name, string password)
        {
            var account = Civ.Logins.Where(x => x.UserName == user_name && x.Password == password).FirstOrDefault();
            return account;
        }

        
    }
}
