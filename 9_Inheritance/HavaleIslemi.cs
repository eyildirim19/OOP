using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Inheritance
{
    public class HavaleIslemi : OdemeIslemi
    {
        public string HesapNo { get; set; }
        public void IslemYap()
        {
            Console.WriteLine($"{ IslemTarihi } tarihinde {HesapNo} nolu hesaba {Tutar} tutarında para gönderildi...");
        }
    }
}