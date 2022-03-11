using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Property
{
    internal class Ogrenci
    {
        internal float Vize { get; set; }
        internal float Final { get; set; }
        // read only property(sadece okunabilir)
        internal float Ortalama
        {
            get
            {
                return Vize * 0.4f + Final * 0.6f;
            }
        }
    }
}