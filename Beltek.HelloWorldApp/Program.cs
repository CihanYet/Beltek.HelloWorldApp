using System;
namespace Beltek.HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldin," + isim);

            Console.ReadKey();
        }
    }
}

//Solution: İçerisinde birden fazla proje bulundurabilen dosyalardır. Solution dosyaları, bu projelerin disk üzerinde kayıtlı oldugu yer bilgisini tutarlar(Path).
//namespace: İçinde classları bulunduran yapılardır.
//{} Scope(Blok) Yapıları:Bu yapılar içerisine birden fazla satır kod yazılabilir.
//class: İçinde metodları bulunduran yapıladır(Şimdilik bu tanım)
//Metod: İş yapan kod bloklarıdır. Main metodu, console uygulamalarının giriş noktasıdır.
//Syntax: Kod yazım kuralları

//C#->Derleme(Compile)->Makina Dili(0,1)
//C#->Derleme->MS-IL->Runtime->Derleme->0,1