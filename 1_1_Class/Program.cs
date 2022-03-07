using _1_1_Class; // Namespace => dosyamızda kullanacağımız komutun genel adıdır...C# dilinde bütün komutlar namespaceler içerisindedir...Namespaceleri soluiton gibi düşünelim....

//Ogrenci => soyut varlık. Sadece tip tanımlaması için kullanıldı...
// ogr => Ogrenci tipinde bir nesnedir...

// Ogrenci ogr => Ogrenci tipinde ogr değişkeni (nesne)
// new Ogrenci() => ogr'ye bellekte yeni bir refarns açar. Bütün alanlar ogr'ye bağlıdır...
Ogrenci ogr = new Ogrenci();
ogr.adisoyadi = "Recep";
ogr.vize = 50;
ogr.final = 70;

Console.WriteLine($"{ogr.adisoyadi}  {ogr.Ortalama() }");

//float sonuc = (ogr.vize + ogr.final) / 2;
Ogrenci ogr2 = new Ogrenci();
ogr2.vize = 90;
ogr2.final = 60;
ogr2.adisoyadi = "Emre";

//float sonuc1 = (ogr2.vize + ogr2.final) / 2;
Console.WriteLine($"{ogr2.adisoyadi} {ogr2.Ortalama()}");

Ogrenci ogr3 = new Ogrenci();
ogr3.vize = 30;
ogr3.final = 100;
ogr3.adisoyadi = "Ahmet";

//float sonuc2 = (ogr3.vize + ogr3.final) / 2;
Console.WriteLine($"{ogr3.adisoyadi} {ogr3.Ortalama()}");

int a = 1;
int b = a;
int c = a + b;