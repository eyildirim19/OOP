using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_AbstractOrnek
{
    public abstract class MyFile
    {
        public abstract void Read();
        public abstract void Write();

    }
    public class ExcelFile : MyFile
    {
        public string path;
        public override void Read()
        {
            // path'ten oku...
        }
        public override void Write()
        {
            // dosyayı yaz...
        }

    }

    public class WordFile : MyFile
    {
        public string path;
        public override void Read()
        {
            // path'ten oku...
        }
        public override void Write()
        {
            // dosyayı yaz...
        }
    }


    public class XmlFile : MyFile
    {
        public string path;
        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
}
