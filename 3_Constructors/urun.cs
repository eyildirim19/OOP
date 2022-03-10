using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructors
{
    internal class Urun
    {
        // constructor (ctor) =>yapıcı metotlar.. yapıcı metotlar bir sınıftan instance alındığında tetiklenen metotlardır. veya bir sınıftan instance almamızı sağlayan metotlardır... ctor ile Sınıf isimleri aynı olmalıdır...

        //ctorlar geneldeilk değerleri set etmek için kullanılır...

        // ctorlar özel metotlardır... dönüş tipi belirtilmez...bu sadece instance alındığıdna tetiklenen metottur...
        internal Urun() // urun sınıfının constructori..
        {
        }

        internal Urun(decimal _fiyat, byte _stok)
        {
            fiyat = _fiyat;
            stok = _stok;
        }

        internal Urun(decimal _fiyat, byte _stok, string tip)
        {
            fiyat = _fiyat;
            stok = _stok;
        }


        internal decimal fiyat;
        internal byte stok;
    }
}
