using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AbstractClass
{
    // abstract class =>soyut sınıf.. soyut sadece miras veren sınıflardır...Abstract classlardan instance alınamaz..
    public abstract class Urun
    {
        // protected => sınıf içerisinde ve miras alan sınıflardan erşilebilir
        public decimal KdvliFiyat { get; protected set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public decimal Fiyat { get; set; }

        protected int Demo { get; set; }
    }
}
