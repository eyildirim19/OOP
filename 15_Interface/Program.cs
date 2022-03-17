using _15_Interface;

ExcelFile exFile = new ExcelFile();
exFile.Name = "Hesaplar";
exFile.Extension = ".xls";
exFile.Path = "C:\\Hesaplar\\";

DosyaIslemleri(exFile);

WordFile wfile = new WordFile();
DosyaIslemleri(wfile);

void DosyaIslemleri(IFile file)
{
    file.Read(); /// file aç...
    // file değişiklik yap....
    file.Write();
}