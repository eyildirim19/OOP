using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polymorphism_1
{
    public class Karga : HayvalarAlemi
    {
        //public void Ses()
        //{
        //    Console.WriteLine("Gak Gak");
        //}
        // override => base'den gelen ezilebilir üyeleri ezmek için kullanılır..
        public override void Ses()
        {
            Console.WriteLine("Gak Gak");
        }
    }
}
