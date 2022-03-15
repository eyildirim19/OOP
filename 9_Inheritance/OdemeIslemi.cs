using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Inheritance
{
    // internal => proje içerisinden
    // public   => proje içi ve dışıarısından...
    public class OdemeIslemi
    {
        // private => sınıf scopeları içerisinden erişilebilirdir...
        public OdemeIslemi()
        {
           IslemTarihi = DateTime.Now; // DateTime tarih sınıfıdır. Now property o anki tarihi verir..
        }

        public string AdiSoyadi { get; set; }
        public DateTime IslemTarihi { get; private set; }
        public string SubeAdi { get; set; }
        public decimal Tutar { get; set; }
    }
}