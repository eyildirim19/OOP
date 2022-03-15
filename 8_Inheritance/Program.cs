
/*
    Inheritance => OOP yaklaşımlarında kapsülleme'den sonra gelen yaklaşımdır...

Inheritance oop'inin önemli yaklaşımıdr. diğer oop yaklaşımları inheritance üzerine kurgulanmıştır. Hatta bir çok yazılım prensibi ve yazılım patterni için de kullanılan yaklaşımdır..
   

    Inheritance (  Miras veya Kalıtım ) => Nesnelerimizi başka neslenelerde türetme işlemidir. veya bir nesnenin özelliklerini başka bir nesne'ye devretme işlemidir...
    
    Inheritance c# dilindede kullanılan bir yaklaşımdır. yani c# temel konusudur..object sınıfı buna en güzel örnektir.

    
    Miras operatörü c# dilinde :'dir. Yani miras almak istersek miras alacağımız sınıfı : ile kullanırız..
    
    Miras veren sınıflar base class olarak, Miras alan sınıflar Derived class olarak adlandırılır..

    
    Derived sınıflar base sınıflar gibi davrandığı için c# dilinde bir class sadece bir classtan türetilebilir....
 */
using _8_Inheritance;

object o; // c# dilinde herşey object sınıfından türetilmiştir.. ToString() metodu object sınıfının üyesidir. bu metoda bütün c# varlıklardan erişebiliriz..yani object bütün tiplerimizin atasıdır...

Insan i = new Insan();

Ogrenci ogr = new Ogrenci();
ogr.AdiSoyAdi = "Recep";
ogr.Cinsiyet = 'E';
ogr.BilgiGoster();
ogr.Dusunce();

Hoca hc = new Hoca();
hc.AdiSoyAdi = "Ekrem";
hc.Cinsiyet = 'E';
hc.BilgiGoster();
hc.Dusunce();

i = ogr; // ogr nesnesi i'ye atanabilir. çünkü ogr i'den türemiştir...

