class Program
{

    static void Main()
    {
        Console.WriteLine("Merhaba OOP");

        /*
            OOP (Object Oriented Programming) (Nesne Yönelimli Programlama)

           Mantıksal işlemler yerine bir modelleme yaklaşımıdır..
           Bir defa yazıp sürekli kullan mantığıdır
         
            Yazılım literatüründe herşey bir varlıktır (Entity)..

            OOP günlük hayattaki varlıkları yazılım ortamında modellemeyi sağlar..
       
            
            bir eticaret sitesinin sanal kart entegrayonunu düşünelim...(UrunFiyati,KartNo, SonKullanimTar,AdiSoyAdi, GuvenlikKodu)
            bir üniversitenin öğrenci otomasyonu geliliyiriyor, Ortalma hesaplama modülünü düşenelim..(DersinAdına,OgrenciAdıSoyadı,Vize,Final;Ortalama)
            bir kütüphane otomoasyonu (Kitap Bilgileri, AlısTarihi,TeslimTarihine)

            OOP'nin ilkeleri veya yaklaşımları;
            1) Encapsulation (Kapsülleme)
            2) Abstraction (Soyutlama)
            3) Inheritance (Miras)
            4) Poliymorphism (Çok biçimlilik)

            // Class oop'inin en temel taşıdır...
            // Class => nesne üretmek için kullanılan yapı.. (birden fazla değişkeni (farklı tipler ile) bir arada tutan çatı).. Classlar günlük hayattaki varlıkları modellediğimiz yapılardır... Class eklemek için solutiondaki  projemizie sağ tık yapıp add class diyerek yeni bir class ekleyebiliriz..Oluşturalacak classlara mantıklı isim vermekte fayda var..Aslınca classlar kendimize ait oluştırduğumuz tiplerimizidir..Bu tipleri değişkenler ile kullanılırız. Bu değişkenlerede nesne deriz..


        // soyut varlıklara (Class)
        // somut varlıklara (Nesne)


         */

        string ogrenciAdi = "Recep", soyadi = "Altun";
        int yas = 25;
        string ogrenciAdi1 = "Kaan", soyAdi1 = "Turan";
        int yas1 = 30;

        ogrenciAdi = "Bilal";
        ogrenciAdi1 = "Ahmet";

        // new Ogrenci() ifadesi ile ogr nesnesi oluştururuz..Bu nesne bellekke kullanılabilir yeni bir nesnedir..

        // Ogrenci oluşturdupumuz class..
        // ogr veya ogr1 bizim nesnemizdir..

        Ogrenci ogr = new Ogrenci();
        ogr.adi = "Recep";
        ogr.soyAdi = "Altun";
        ogr.yas = 26;

        Ogrenci ogr1 = new Ogrenci(); // ogr1 nesnesi oluştur..
        ogr1.adi = "Kaan";
        ogr1.soyAdi = "Turan";
        ogr1.yas = 30;


        Ogrenci ogr3 = new Ogrenci();
        ogr3.adi = "Ahmet";
        ogr3.soyAdi = "Kurt";
        ogr3.yas = 19;

    }
}