using _12_Polymorphism_2;

Console.WriteLine("******************ABSTRACT ÜYELER****************");





Tufek t = new Tufek();
Tabanca ta = new Tabanca();

Silah s1 = t;

Silah s2 = ta;



Console.WriteLine("************ nesne üzerinden **************");
t.AtesEt();
ta.AtesEt();

Console.WriteLine("************ base üzerinden **************");
s1.AtesEt();
s2.AtesEt();
