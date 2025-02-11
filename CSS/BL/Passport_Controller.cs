 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSS.BL
{
    static class Passport_Controller
    {
       static Civil_statusEntities1 Civ = new Civil_statusEntities1();
        

        public static Passport Search_For_Passport_Card(string Enc_ID)
        {
            
            var data = Civ.Passports.Where(x => x.ID_Passport_Number == Enc_ID).FirstOrDefault();
            return data;
        }
        public static void Add_Passport_Card(Passport Passport_Card)
        {
            Civ.Passports.Add(Passport_Card);
            Civ.SaveChanges();
        }
        public static string Encrypt_Passport_Card_num(string plean_txt)
        {
            string encry_txt = Convert.ToBase64String(Encoding.UTF8.GetBytes(plean_txt));
            return encry_txt;

        }
    }
}
