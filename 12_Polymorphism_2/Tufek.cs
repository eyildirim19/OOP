using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism_2
{
    public class Tufek : Silah
    {
        // eğer abstract üye varsa miras alan sınıf hata verecektir. Bu hatanın önüne geçmek için base üyelerin override edilmesi gerekir. override yazarak veya 
        public override void AtesEt()
        {
            Console.WriteLine("tak tak");
        }

        public override decimal Menzil()
        {
            return 500;
        }
    }
}
