using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    public class ExcelFile : BaseFile, IFile
    {
        public void Read()
        {

            Console.WriteLine($"{Path} yolundan {Name}.{Extension} dosyasını okudum...işimi bitirdim...");
        }

        public void Write()
        {

            Console.WriteLine($"{Path} yoluna {Name}.{Extension} dosyasını yazdım...");
        }
    }
}
