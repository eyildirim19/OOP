/*
    Soyutlama => Nesnelerin soyutlanmasıdır. 
    Absract class   => Soyut sınıf.. Sadece miras vermek için kullanılır..
 */
using _10_AbstractClass;

Telefon tl = new Telefon();
tl.Marka = "Iphone";
tl.Model = "se";
tl.Fiyat = 8000;
//tl.Kdv = 8; read only property..sadece okunabilir...

TV tv = new TV();
tv.Marka = "Samsung";
tv.Model = "s22";
tv.Fiyat = 5000;

//Urun u = new Urun(); instance alamıyoruz. çünkü Urun sınıfı abstract sınıftır...
int a = 1;
Urun[] urunSepeti = new Urun[3];
//urunSepeti[0] = new Urun(); urunden instance alınamaz...
urunSepeti[0] = tl;
urunSepeti[1] = tv;
urunSepeti[2] = new Telefon();
urunSepeti[2].Marka = "Samsung";
urunSepeti[2].Model = "Galaxy";
urunSepeti[2].Fiyat = 4000;

foreach (Urun item in urunSepeti)
{
    if (item is TV)
    {
        TV tempNesne = (TV)item;
        tempNesne.KdvHesapla();
    }
    else if (item is Telefon)
    {
        Telefon temp = (Telefon)item;
        temp.KdvHesapla();
    }
    Console.WriteLine($"{item.Marka} {item.Model} {item.Fiyat} {item.KdvliFiyat}");
}