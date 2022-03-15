using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AbstractClass
{
    public class Telefon : Urun
    {
        public void KdvHesapla()
        {
            KdvliFiyat =  Fiyat * 1.08m;
        }
    }
}
