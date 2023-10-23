Console.WriteLine("iki sayiyi toplayan program");
Console.Write("1. sayiyi giriniz :");
int sayi1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("2. sayiyi giriniz :");
int sayi2 = Convert.ToInt16(Console.ReadLine());

int toplam = sayi1 + sayi2;
Console.Write("toplam = {0} + {1} = {2}", sayi1, sayi2, toplam);
Console.ReadKey();