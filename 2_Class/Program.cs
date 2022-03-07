using _2_Class;

int[] a = { 1, 2, 3, 4, 5 };// object initializer
int[] b;
//b ={1,2,3,4,5 }; bu şekilde atama söz konusu olamaz.Sadece aşağıdaki kod örneğindeki gibi kullanabilirsiniz...
b = new int[] { 1, 2, 3, 4, 5 };

Islem islem = new Islem();
islem.nums = new int[] { 5, 1, 3, 4, 2 };

Islem islem2 = new Islem();
islem2.nums = new int[] { 4, 3, 2, 1 };

islem.Sort();
islem2.Sort();

Console.WriteLine("Dizinin son hali...");
islem.Print();
islem2.Print();


// CONSTRUCTORS
// INSTANCE
// ENCAPSULATION (OOP)