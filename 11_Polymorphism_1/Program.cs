/*
    Polymorphism (Çok biçimlilik) =>  Base sınıfların üyelerinin alt sınıflarda farklı davranabilmesidir....
 */
using _11_Polymorphism_1;


Console.WriteLine("****************VIRTUAL ÜYELER*******************")

Kus k = new Kus();
k.Tur = "Serçe";
k.Ses(); // Cik cik

Karga ka = new Karga();
ka.Tur = "Ak";
ka.Ses(); // gak gak


Console.WriteLine("***************************************");

HayvalarAlemi[] hayvanatBahcesi = new HayvalarAlemi[3];
hayvanatBahcesi[0] = k;
hayvanatBahcesi[1] = ka;
hayvanatBahcesi[2] = new Kedi();

foreach (HayvalarAlemi item in hayvanatBahcesi)
{
     item.Ses(); // gak gak...
}