using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Inheritance
{
    internal class Insan
    {
        public string AdiSoyAdi { get; set; }

        public char Cinsiyet { get; set; }
        public void BilgiGoster()
        {
            Console.WriteLine($"Merhaba, benim adım {AdiSoyAdi}");
        }
    }

    internal class Ogrenci : Insan // Ogrenci sınıfı insan sınıfından türedi..veya Ogrenci sınıfı için Insan sınıfından miras aldık
    {
        public float Sınav { get; set; }

        public void Dusunce()
        {
            Console.WriteLine("Hoca anlatamıyor!");
        }
    }

    internal class Hoca : Insan
    {
        public decimal Maas { get; set; }

        public void Dusunce()
        {
            Console.WriteLine("Öğrenciler anlamıyor!");
        }
    }
}