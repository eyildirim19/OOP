using _5_Encapsulation;


string e = "Denm";
string a = "Recep r";
string s = "deneme deneme denme denme e";

MusteriFormu form = new MusteriFormu();
form.SetEmail(e);
form.adisoyadi = a;
form.SetSikayet(s);


MusteriFormu form1 = new MusteriFormu();
Console.WriteLine("Email Giriniz");
form1.SetEmail(Console.ReadLine());

Console.WriteLine("Adınız SoyAdınız");
form1.adisoyadi = Console.ReadLine();

Console.WriteLine("Şikatetiniz....");
form1.SetSikayet(Console.ReadLine());

MusteriFormu frm2 = new MusteriFormu();
frm2.SetEmail("bt@btakademi.com");
frm2.SetSikayet("Havalar çok soğuk....");
frm2.adisoyadi = "E Y";


Console.WriteLine(frm2.GetEmail());
Console.WriteLine(frm2.GetSikayet());