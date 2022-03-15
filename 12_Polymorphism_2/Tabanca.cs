using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism_2
{
    public class Tabanca : Silah
    {
        // Base sınıfımızda üyelerimiz abstract olduğu için override edilmelidir...

        public override void AtesEt()
        {
            Console.WriteLine("Tak tuk");
        }

        public override decimal Menzil()
        {
            return 300;
        }
    }
}
