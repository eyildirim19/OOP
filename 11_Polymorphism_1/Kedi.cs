using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Polymorphism_1
{
    public class Kedi : HayvalarAlemi
    {
        // eğer override yazarsınız base'den ezilebilir üyeleri görürsünüz...
        public override void Ses()
        {
            Console.WriteLine("Miyav Miyav");
        }
    }
}
