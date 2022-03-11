using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Property
{
    internal class MusteriFormu
    {
        //veriler sınıflarda fieldlarda saklanır...Bu yüzden fieldar sınıfların en önemli üyeleridir...

        // metotlar sınıflar içerisindeki alt programlarımız veya üyelere erişim için kullanılan program bloklarıdır...

        // Property => hem field hemde metot yerine kullanılabilen yapılardır..Özellikle fieldlara erişim söz konusu ile property kullanırız...
        /*
            erisimSeviye veriTipi PropertyAd
            {
                set{
                    value=> propertye atanan değeri ifade eder....
            } // deger atamak için
                get; // deger okumak için 
            }

        // property içerisindeki set parametre alan void metodu, get geriye değer donustipli metodu ifade eder...propert tipi paremetrenin ve get motdununun donustipini belirler

         */

        private string email;
        internal string Email
        {// deneme.aaksdjl sjlk
            set // setter metot
            {
                if (value.Contains("@") && value.Contains(".")) // Regex...
                {
                    email = value;
                }
                else
                    throw new Exception("Geçersiz Email Adresi");
            }
            get // getter metot
            {
                return email;
            }
        }

        private string sikayet;
        internal string Sikayet
        {
            get
            {
                return sikayet;
            }
            set
            {
                if (value.Length > 10)
                    sikayet = value.Substring(0, 10);
                else
                    sikayet = value;
            }
        }

        // kısıtlaması olmayan bir field
        private string adsoyad;
        internal string AdSoyAd
        {
            set
            {
                adsoyad = value;
            }
            get
            {
                return adsoyad;
            }
        }

        // Eğer fieldlar kapsüllenmeyecekse propertyler field yerine tanımlanabilir ve kullanılabilir.. propertyler'de get ve set bloğu ezilmezse (açılmazsa) gizli bir field kullanır...
        internal string Konu { get; set; } // konu property'si bizim görmediğimiz ancak çalışma zamanında oluşan gizli bir fieldi işaret ederler...
        internal string Telefon { get; set; }

        //NOT : eğer property'nin get veya set bloğu içerisine kod yazılırsa diğer bloğunu'da tamamlmak gerekiyor. Çünkü bu bloklardan birisi açıldığında gizli field iptal olur...Alt satıdaki yortum satırını açarsanız hatayı görürsünüz...
        //int a;
        //internal int Yas
        //{
        //    get; set
        //    {
        //        a = value;
        //    }
        //}
    }
}
