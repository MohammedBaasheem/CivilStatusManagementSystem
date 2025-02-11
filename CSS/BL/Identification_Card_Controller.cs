using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSS.BL
{
    static class Identification_Card_Controller
    {

        static Civil_statusEntities1 Civ = new Civil_statusEntities1();


        public static Identification_Card Search_For_Identification_Card(string Enc_ID)
        {

            var data = Civ.Identification_Cards.Where(x => x.ID_Number == Enc_ID).FirstOrDefault();
            return data;
        }
        public static void Add_Identification_Card(Identification_Card identification_card)
        {
            Civ.Identification_Cards.Add(identification_card);
            Civ.SaveChanges();
        }
        
        public static string Encrypt_Identification_Card_num(string plean_txt)
        {
            string encry_txt = Convert.ToBase64String(Encoding.UTF8.GetBytes(plean_txt));
            return encry_txt;

        }

        //    public static string Encrypt_Passport_Card_num(string plean_txt)
        //    {
        //        string encry_txt = Convert.ToBase64String(Encoding.UTF8.GetBytes(plean_txt));
        //        return encry_txt;

        //    }
        //
    }
}
