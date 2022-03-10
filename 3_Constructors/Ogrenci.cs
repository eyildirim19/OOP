using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructors
{
    internal class Ogrenci
    {

        internal Ogrenci()
        {

        }

        internal Ogrenci(string fname, string lname, int age)
        {
            adi = fname;
            soyadi = lname;
            yas = age;
        }

        internal string adi;
        internal string soyadi;
        internal int yas;
    }
}
