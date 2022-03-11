using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Encapsulation
{
    internal class MusteriFormu
    {
        // email formatına uygun mu??
        private string email;
        internal void SetEmail(string deger)
        {
            if (deger.Contains("@") == true)
            {
                if (deger.Contains("."))
                    email = deger;
            }
            else
                throw new Exception("Geçersiz Email Adresi..."); // yeni bir hata fırlatıyoruz..
        }
        internal string GetEmail()
        {
            return email;
        }


        internal string adisoyadi;
        // 10 karakter girilebilsin...eğer 10 karakterden fazla girilirse 10 karakter alınsın...
        private string sikayet;
        internal void SetSikayet(string deger)
        {
            if (deger.Length > 10)
                sikayet = deger.Substring(0, 10); // Substring => string içerisinden belli sayıda karakter almamızı sağlar
            else
                sikayet = deger;
        }
        internal string GetSikayet()
        {
            return sikayet;
        }
    }

    // erisimseviyesi uyeTipi UyeAdi
}
