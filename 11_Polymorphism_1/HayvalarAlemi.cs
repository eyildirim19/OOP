using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polymorphism_1
{
    public class HayvalarAlemi
    {
        public string Tur { get; set; }
        public void Bilgileri()
        {
            Console.WriteLine(Tur);
        }

        // virtual üyeler => Alt sınıflar tarafından gövdesi ezilebilir üyelerdir....alt sınıflar tarafından override komutu ile ezilebilirler....
        public virtual void Ses()
        {
            Console.WriteLine("Cik cik");
        }
    }
}
