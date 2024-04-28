using System;
namespace Beltek.HelloWorldApp
{
    internal class Program
    {
        static int number = 10;
        static void Main(string[] args)
        {
            //double maas = 5000;
            //maas += 1000;
            //Console.WriteLine(maas);

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //string sonuc = sayi1 > sayi2 ? "Sayı 1 Büyüktür" : "Sayı 2 büyüktür yada sayılar eşittir";
            //Console.WriteLine(sonuc);

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bir sayı daha giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Sayı 1 büyüktür");
            //}
            //else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine("Sayı 2 büyüktür");
            //}           
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir");
            //}

            //Hava nasıl?
            //Güzel
            //Dışarı çık
            //Kötü
            //Evde Otur
            //Sadece güzel veya kötü cevapları verebilirsiniz.

            //try
            //{
            //    Console.WriteLine("Hava nasıl?");
            //    string durum = Console.ReadLine().ToLower();
            //    if (durum == "güzel")
            //    {
            //        Console.WriteLine("Kaç derece?");
            //        sbyte derece = sbyte.Parse(Console.ReadLine());
            //        if (derece < 10)
            //        {
            //            Console.WriteLine("Hava soğuk evde otur");
            //        }
            //        else if (derece >= 10 && derece <= 30)
            //        {
            //            Console.WriteLine("Hava güzel dışarı çık");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Çok sıcak evde otur");
            //        }
            //    }
            //    else if (durum == "kötü")
            //    {
            //        Console.WriteLine("Evde otur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sadece güzel/kötü değeri girilebilir.");
            //    }
            //}
            //catch(OverflowException)
            //{

            //}
            //catch(FormatException)
            //{

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bir hata oluştu!");
            //}



            //Console.WriteLine("1-Havale\n2-Eft\n3-İnternet Bankacılığı\n4-Müşteri Hizmetleri");
            //byte secim = byte.Parse(Console.ReadLine());
            //if (secim == 1)
            //{
            //    Console.WriteLine("Havale işlemleri");
            //}
            //else if (secim == 2)
            //{
            //    Console.WriteLine("Eft işlemleri");
            //}
            //else if (secim == 3)
            //{
            //    Console.WriteLine("İnternet bankacılığı");
            //}
            //else if (secim == 4)
            //{
            //    Console.WriteLine("Müşteri hizmetleri");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız");
            //}

            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine("Havale işlemleri");
            //        break;
            //    case 2:
            //        Console.WriteLine("Eft işlemleri");
            //        break;
            //    case 3:
            //        Console.WriteLine("İnternet bankacılığı");
            //        break;
            //    case 4:
            //        Console.WriteLine("Müşteri Hizmetleri");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız");
            //        break;
            //}

            Console.WriteLine("Şekil seçiniz:\n1-Kare\n2-Daire\n3-Üçgen");
            byte secim = byte.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Bir kenar uzunluğunu giriniz:");
                    byte kenar = byte.Parse(Console.ReadLine());
                    Console.WriteLine($"Karenin alanı:{kenar * kenar}");
                    break;
                case 2:
                    Console.WriteLine("Yarıçap giriniz:");
                    byte yaricap = byte.Parse(Console.ReadLine());
                    Console.WriteLine($"Dairenin alanı:{Math.PI * yaricap * yaricap}");
                    break;
                case 3:
                    Console.WriteLine("Taban uzunluğu giriniz:");
                    byte taban = byte.Parse(Console.ReadLine());
                    Console.WriteLine("Yüksekliği giriniz:");
                    byte yukseklik = byte.Parse(Console.ReadLine());
                    Console.WriteLine($"Üçgenin alanı:{(taban * yukseklik) / 2}");
                    break;
                default:
                    Console.WriteLine("Hatalı seçim");
                    break;
            }
        }
    }
}
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

#region Tür Dönüşümleri
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
#endregion

#region Exception Handling
//Exception Handling
//try
//{
//    Console.WriteLine("Adınızı Giriniz:");
//    string isim = Console.ReadLine();
//    Console.WriteLine("Soyadını Giriniz:");
//    string soyad = Console.ReadLine();
//    Console.WriteLine("Yaşınızı giriniz:");
//    byte yas = byte.Parse(Console.ReadLine());
//    Console.WriteLine($"Adınız:{isim}\nSoyadınız:{soyad}\nYaşınız:{yas}");
//    Console.ReadKey();
//}
//catch(FormatException)
//{
//    Console.WriteLine("Yaşınızı sayı ile giriniz.");    
//} 
//catch(OverflowException)
//{
//    Console.WriteLine("Yaşınızı 0-255 arası girebilirsiniz..");
//}
//catch (Exception)
//{
//    Console.WriteLine("Bir hata oluştu");
//} 
#endregion

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

//Debug: Hata ayıklama F5 ile başlatılır.

//Handled Exception: Try catch ile yakalanmış ve exception durumunda yapılacak işlemlerin tanımlandığı durumdur.

//Metod Parametresi: Metodların işlerini yapabilmek için ihtiyaç duydukları verilere denir ve metod parantezleri içerisinde metoda gönderilir.

// 1 && 1 = 1
// 1 && 0 = 0
// 0 && 1 = 0
// 0 && 0 = 0

// 1 || 1 = 1
// 1 || 0 = 1
// 0 || 1 = 1
// 0 || 0 = 0
