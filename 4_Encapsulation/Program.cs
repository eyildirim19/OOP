using _4_Encapsulation;
/*
encapsulation (kapsülleme) => oop yaklaşımlardan biridir..bir sınıfın üyelerine (gerektiğinde) erişimin kısıtlanmasıdır (engellenmesi veya sadece kısıtlı şekilde erişilmesidir)
 */

// Öğrencinin yaşı 18'den küçük olamaz. eğer 18'den küçük değer girilirse öğrencin yaşı 18 kabul edilsin...

Ogrenci ogr = new Ogrenci();
ogr.ad = "Recep";
ogr.SetYas(15);
Console.WriteLine(ogr.GetYas());

Ogrenci ogr1 = new Ogrenci();
ogr1.ad = "Kaan";
ogr1.SetYas(24);
Console.WriteLine(ogr1.GetYas());

Ogrenci ogr3 = new Ogrenci();
ogr3.ad = "Ahmet";
ogr3.SetYas(17);
Console.WriteLine(ogr3.GetYas());

Ogrenci ogr4 = new Ogrenci();
ogr4.ad = "SÜmeyye";
Console.WriteLine(ogr4.GetYas()); // 0. çünkü set metotu kullanmadık...

// C# PROPERTYLER KONUSUDUR..