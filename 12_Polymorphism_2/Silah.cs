using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polymorphism_2
{
    public abstract class Silah
    {
        // abstract üyeler => gövdesi alt sınıflar tarafından tanımlanan metotlardır..yani abstract üyelerin gövdeleri olmaz...

        // virtual üyeler => gövdeleri base ve alt sınıflar tarafından tanımlanır. gövde tanımlanmak zorunludur...

        //abstract üyeler alt sınıflar tarafından ezilmek zorundadır..
        // virtual üyelerde böyle bir zorunluluk yoktur. Sadece ezilebilir. 

        // abstract üyeler sadece abstract classlarda yazılabilir...
        // virtual üyeler bütün sıfınlarda yazılabilir..
        public abstract void AtesEt();
        public abstract decimal Menzil();

        public void Deneme()
        {

        }
        public  string temp { get; set; }
    }
}