using System;
using _9_Inheritance;

class Program
{
    static void Main()
    {
        EftIslemi eft = new EftIslemi();
        eft.AdiSoyadi = "Recep";
        eft.IbanNo = "12313131231";
        //   eft.IslemTarihi = DateTime.Now; // Not : işlem tarihi instance alındığında set edilsin... Sınıf dışında tarih set edilmesin. çünkü bizim sistemiz henüz tarih belirlenerek ödeme işleme yapamamamktadır...
        eft.Tutar = 150;

        HavaleIslemi havale = new HavaleIslemi();
        havale.AdiSoyadi = "Ekrem";
        havale.HesapNo = "4321";
        havale.Tutar = 5000;

        /*
         eft.IslemYap();
        havale.IslemYap();
        
        int a = 1;
        byte b = 2;
        a = b;
        b = (byte)a; // cast işlemi, büyükten küçüke dönüşüm...

        OdemeIslemi odv = eft;
        EftIslemi tef = (EftIslemi)odv; // cast işlemi... odv'yi tef'e dönüştür.. odv'nin referansı tef'e set edilir...
        */

        Transfer transer = new Transfer();
        transer.ParaGonder(eft);
        transer.ParaGonder(havale);


        int a = 3;
        // is operatörü => tip eşitliğidir..
        if (a is int) // a nin tipi int mi?
        {

        }

        if (a == 3)// a'nın değeri 3 mü?
        {

        }
    }
}