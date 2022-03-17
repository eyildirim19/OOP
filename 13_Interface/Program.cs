

// Abstract sınıflardan instance alınamaz. ama derived sınıfların referanslarını tutarbilir..

using _13_AbstractOrnek;
ExcelFile exFile = new ExcelFile();
exFile.path = "c:\\raporlar\\satisRaporlari.xls";

DosyaIslemleri(exFile);

WordFile wFile = new WordFile();
wFile.path = "c:\\sablonlar\\yazi.xdoc";

DosyaIslemleri(wFile);



XmlFile xFile = new XmlFile();
xFile.path = "http://www.denemec.com/rapoar.xml";
DosyaIslemleri(xFile);


void DosyaIslemleri(MyFile file) // dosya okuma modülü...
{
    file.Read(); // dosyayı okuyruz.
    file.Write();//kaydet....

}