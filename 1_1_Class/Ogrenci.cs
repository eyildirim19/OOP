using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_Class
{
    internal class Ogrenci
    {
        // Sınıfları oluştaran yapılara class members(sınıf üyeleri denir)
        // field => classların alanlarıdır...veriler  bu üyelerde saklanır. Örneğin ogrenciAdi,ürünfiyatı,ürünstoku,otomobil motor gucu vs...
        // property => özel bir konudur. field veya metot yerine kullanılabilir... (Encapsulation konusunda detaylandırılacaktır)
        // metot => class içerisinde yazdığımız programlarımız...OgrenciKaydı, DiziElemanSılaması vs. vs.
        internal string adisoyadi;
        internal float vize;
        internal float final;
        // geriye float dönen metot..

        // NOT : class üyeleri class seviyesinde erişelemez. Sadece üye içerisinden (alt scope) erişilebilirler...
        //internal float ortalama = vize;

        internal float Ortalama()
        {
            return vize * 0.4f + final * 0.6f;
        }
    }
}
