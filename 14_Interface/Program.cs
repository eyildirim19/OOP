/*
 * interface  => ara birim veya arayüz olarak çevirebiliriz... sınıflarımıza yetenek kazandırmak için kullanılır...
 * 
    abstract class benzer
    multiple inheritance yapısı
    yol gösterici
    
    c# dilinde oop'nin 

    interface adlarının önüne I eklenir.IInterfaceAdi
 */
using _14_Interface;
//Interface1 iii = new Interface1(); // Interfaceler'den instance alınamaz. yani nesne oluşturululamaz..

string str = "";

//IOrnek orn = new IOrnek(); // instace alınamaz
IOrnek orn = new Ornek(); // Ornek nesne referransı tutabilir..
orn.Carp();
orn.BenBirMetot();


IOrnek orn2 = new Ornek2();
orn2.BenBirMetot();

IDemo dem = new Ornek();
dem.Bol();


