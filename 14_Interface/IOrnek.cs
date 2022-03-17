using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Interface
{

    //C# 8.0'dan önce;
    // interface üyelerinin gövdeleri olamaz...çünkü interface üyeleri abstract kabul edilir...
    // interface üyelerinin erişim seviyeleri private olamaz..çünkü soyut varlıklardır. soyut metot tanımlanamsının bir mantığı olamaz...
    // interfacelerde field tanımlanamaz...
    // interface üyeleriin erişm seviyesi olmaz..üyeler public/internal kabul edilir..
    public interface IOrnek
    {
        void Carp();

        void Cikar();

        void Mod();


        // Default metot 8.0 ile birlikte...
        // miras alan sınıflar tarafından implement edilme zorunluluğ yoktur... 
        public void BenBirMetot()
        {
            Console.WriteLine("ben default metot..ben yeniyim...");
        }
    }


    public interface IOrn
    {
        int MyProperty { get; set; }
    }

    public interface IDemo
    {
        void Topla();
        void Bol();
    }
    // NOT : interface üyeleri miras alan sınıflar tarafından implement edilmek zorundadır...
    // implement etmek interface üyelerinin tamamlanmasıdır.. veya uygulanmasıdır...

    // Ornek sınıfı IOrnek interfacesinden mrias aldı...
    // interfaceler sınıflara yetenek kazandırmak için kullanılan yapılardır. Interfacelerin kendileri tek başına bir işe yaramazlar. Miras alan sınıflar interfacelerin tamamlayıcılarıdır..

    // birden fazla yapıdan miras almak için miras alınan yapıdan sonra ,  kullanıırz
    // NOT: Bir sınıf sadece bir miras alabilir. ancak birden fazla interfaceden miras alabilir....
    public class Ornek : IOrnek, IDemo, IOrn
    {
        // bu yazım tekniğini c# konusunda işleriz...
        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Bol()
        {
            throw new NotImplementedException();
        }

        public void Carp()
        {
            throw new NotImplementedException();
        }

        public void Cikar()
        {
            throw new NotImplementedException();
        }

        public void Mod()
        {
            throw new NotImplementedException();
        }

        public void Topla()
        {
            throw new NotImplementedException();
        }
    }

    public class Ornek2 : IOrnek
    {
        public void Carp()
        {
            throw new NotImplementedException();
        }

        public void Cikar()
        {
            throw new NotImplementedException();
        }

        public void Mod()
        {
            throw new NotImplementedException();
        }
    }

}
