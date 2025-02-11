using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSS.BL
{
    static class Manager
    {
        static Civil_statusEntities1 Civ = new Civil_statusEntities1();
        static public void Add_Employee(Login Employee)
        {
            Civ.Logins.Add(Employee);
            Civ.SaveChanges();
            
        }
        static public void Delete_Employee(int ID_Employee)
        {
            Login Employee = Civ.Logins.Where(x => x.ID_User == ID_Employee).FirstOrDefault();
            Civ.Logins.Remove(Employee);
            Civ.SaveChanges();
        }
        static public Login Search_for_Employee(int ID_Employee)
        {
            Login Employee = Civ.Logins.Where(x => x.ID_User == ID_Employee).FirstOrDefault();
            return Employee;
        }

    }
}
