using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Interface
{
    public class WordFile : BaseFile, IFile
    {
        public void Read()
        {
            // hata fırlatıyrum....
            //throw new Exception("Excel formatı güncellenmeli....");

            Console.WriteLine($"{Path} yolundan {Name}.{Extension} dosyasını okudum...");

            Console.WriteLine("1. satır okuyorum...");
            Console.WriteLine("2. satır okuyorum...");
            Console.WriteLine("3. satır okuyorum...");
            Console.WriteLine("4. satır okuyorum...");
        }

        public void Write()
        {
            Console.WriteLine("Dosyayı kaydettim...");
        }
    }
}
