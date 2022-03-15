using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Inheritance
{
    public class EftIslemi : OdemeIslemi
    {
        public string IbanNo { get; set; }
        public void IslemYap()
        {
            Console.WriteLine($"{ IslemTarihi } tarihinde {IbanNo} nolu ibana {Tutar} tutarında para gönderildi...");
        }
    }
}