using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSS.BL
{
    public static class Birth_certificate_Controller
    {
        static Civil_statusEntities1 Civ = new Civil_statusEntities1();
        

        public static Birth_Certificate Search_For_Birth_Certificate(string Enc_ID)
        {
            var data = Civ.Birth_Certificates.Where(x => x.ID_Number_Born == Enc_ID).FirstOrDefault();
            return data;
        }
        public static void Add_Birth_Certificate(Birth_Certificate birth_card)
        {
            Civ.Birth_Certificates.Add(birth_card);
            Civ.SaveChanges();
        }
        public static string Encrypt_Birth_Certificate_num(string plean_txt)
        {
            string encry_txt = Convert.ToBase64String(Encoding.UTF8.GetBytes(plean_txt));
            return encry_txt;

        }
    }
}
