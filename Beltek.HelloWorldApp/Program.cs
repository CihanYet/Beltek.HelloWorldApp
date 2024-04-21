using System;
namespace Beltek.HelloWorldApp
{
    internal class Program
    {
        static int number = 10;
        static void Main(string[] args)
        {
            #region Değişkenler
            //Console.WriteLine("Adınızı giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Hoşgeldin," + isim);

            //byte yas;
            //Console.WriteLine(yas);

            //Int16 sayi = 5;
            //Int32 _sayi = 5;
            //Int64 __sayi = 5;

            //byte sayi = 50;//Explicit
            //var _sayi = 50;//Implicit

            //string isim = "Ahmet";
            //string soyad = "Mehmet";

            //Console.Write(isim);
            //Console.WriteLine(soyad);

            //Console.WriteLine("Hoşgeldin, " + isim + " " + soyad);
            //Console.WriteLine("Hoşgeldin, {0} {1}", isim, soyad);
            //Console.WriteLine($"Hoşgeldin, {isim} {soyad}"); 
            #endregion

            Console.WriteLine("Adınızı Giriniz:");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyadını Giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz:");
            byte yas = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Adınız:{isim}\nSoyadınız:{soyad}\nYaşınız:{yas}");



            //****Tür Dönüşümleri(Type Casting)****
            //Type-Safety

            //byte sayi = 5;
            //int number = sayi;//Implicit Type Casting

            //checked
            //{
            //    int sayi = 257;
            //    byte number = (byte)sayi;//Explicit Type Casting
            //    Console.WriteLine(number); 
            //}

            //string sayi = "25";
            //byte number = Convert.ToByte(sayi);

            //byte _number = byte.Parse(sayi);

            //int sayi = 50;
            //object number = sayi;//Boxing
            //int sayi2 = 10;
            //int sonuc = (int)number + sayi2;//Unboxing



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

//IntelliSense: Kod yazarken açılan yardımcı pencere
//IntelliCode: Yapay Zeka Kod yazım yardımcısı