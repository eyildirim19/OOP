using _3_Constructors;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// value     =>tutalan değerdir
// references =>tutulan referansdır

// value      type     (değer) =>  değer tutan tipler
// references type (referans)  =>  referans tutan tipler
// diziler referans types'a örnek verilebilir...çünkü birden fazla aynı tipten değişkenin değerini tutar...


// instance => new ifaedsi ile bir değişkene referrans oluşturma işlemidir.bellekte yeni bir alan açarsınız....
int sayi = 55555;
double sonuc = sayi + 2;
bool bl = true;
byte bv = 2;

string str = "niye value????";
char[] chr = { 'n', 'i', 'y', 'e', 'v', 'a', 'l', 'u', 'e', '?', '?', '?' };

int[] sayis = new int[3]; // 3 elemanlı bir dizi..
sayis[0] = 1;
sayis[1] = 1;
sayis[2] = 1;

// değişken
int result = 5 + sayis[2];

//değişken
int[] nums = new int[3];
int[] nums2 = new int[5];

// nesne..
Ogrenci ogr = new Ogrenci("Recep", "D", 23);
Console.WriteLine(ogr.adi); // Recep

Ogrenci ogr43 = new Ogrenci("Bilal", "D", 23);
Console.WriteLine(ogr43.adi); // Recep

Ogrenci ogr1 = new Ogrenci();
ogr1.adi = "Sümeyye";
ogr1.yas = 30;


Ogrenci ogr33 = new Ogrenci();
ogr33.adi = "aslda";
ogr33.soyadi = "aa";

int b = sayi;    // sayiyi b'eye ata...
Ogrenci ogr3 = ogr; // ogr nesnesini ogr3'e ata
ogr3.adi = "Kaan";
Console.WriteLine(ogr3.adi); // Kaan
Console.WriteLine(ogr.adi); // Kaan



Urun u = new Urun();
u.fiyat = 44;
u.stok = 100;

Urun ıı = new Urun(110, 1);
Console.WriteLine(ıı.fiyat); // 110


char[] ichar = { 'e','k','r','e','m'};
string str22 = new string(ichar);