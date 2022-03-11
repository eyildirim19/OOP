using _6_Property;

MusteriFormu frm = new MusteriFormu();
frm.Email = "deneme@bt.com"; // set etmek.....
frm.Sikayet = "havalar çok soğuk"; //set... 
frm.AdSoyAd = "Ekrem Yıldırım"; // set..
frm.AdSoyAd = "Ders"; // set 
frm.Telefon = "123456"; // set

string s = frm.Email;// get etmek
Console.WriteLine(frm.Email); // get etmek
Console.WriteLine(frm.Sikayet); // get 
Console.WriteLine(frm.AdSoyAd); // get
Console.WriteLine(frm.Konu);
Console.WriteLine(frm.Telefon);


//MusteriFormu frm2 = new MusteriFormu();
//frm2.Email = "deneme";
//Console.WriteLine(frm2.Email);