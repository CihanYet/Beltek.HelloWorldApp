namespace Beltek.DongulerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("İsminizi giriniz:");
            //string ad = Console.ReadLine();

            //Console.WriteLine("Kaç kere yazılsın?");
            //byte adet = byte.Parse(Console.ReadLine());

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine($"{i + 1}-{ad}");
            //}



            //Console.WriteLine("Başlangıç değeri giriniz:");
            //byte bas = byte.Parse(Console.ReadLine());

            //Console.WriteLine("Bitiş değeri giriniz:");
            //byte bit = byte.Parse(Console.ReadLine());

            //Console.WriteLine("Tek-Çift?");
            //string secim = Console.ReadLine();

            //int sonuc = 0;

            ////bas:10
            ////bit:5

            //if (bas > bit)
            //{
            //    byte temp = bas;
            //    bas = bit;
            //    bit = temp;
            //}

            //for (int i = bas; i < bit; i++)
            //{
            //    //if (secim == "çift" && i % 2 == 0)
            //    //{
            //    //    sonuc += i;
            //    //    Console.WriteLine(i);
            //    //}
            //    //else if (secim == "tek" && i % 2 == 1)
            //    //{
            //    //    sonuc += i;
            //    //    Console.WriteLine(i);
            //    //}

            //    if (i % 2 == (secim == "tek" ? 1 : 0))
            //    {
            //        sonuc += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine($"İşlemin sonucu:{sonuc}");

            //3-4-5
            //int sonuc = 0;
            //sonuc = sonuc + 3;//sonuc+=3
            //sonuc = sonuc + 4;//sonuc+=4
            //sonuc = sonuc + 5;//sonuc+=5
            //Console.WriteLine(sonuc);


            //Console.WriteLine("Taban değeri giriniz:");
            //int taban = int.Parse(Console.ReadLine());
            //Console.WriteLine("Üs değer giriniz:");
            //int us = int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc *= taban;
            //}
            //Console.WriteLine(sonuc);

            //int result = 1; 
            //for (int i = 0; i < 20; i++)
            //{
            //    result = result * 2;
            //}
            //Console.WriteLine(result);


            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine($"İşlemin sonucu:{sonuc}");

            //int result = 1;            
            //result = result * 2;
            //result = result * 3;



            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 2; i <= sayi / 2; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;
            //    }
            //}
            //Console.WriteLine(sayac == 0 ? "Asal" : "Asal değil");



            //for (int i = 2; i <= sayi / 2; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;
            //    }
            //}
            //Console.WriteLine(sayac == 0 ? "Girilen Sayı asal" : "Asal değil");


            //for (; ; )
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz:");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("Şifre giriniz:");
            //    string password = Console.ReadLine();

            //    if (user == "admin" && password == "123")
            //    {
            //        Console.WriteLine("Giriş başarılı!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş, tekrar deneyiniz...");
            //    }
            //}



            //Sayı giriniz:
            //5
            //Devam etmek istiyor musunuz?E
            //Sayı giriniz:
            //10
            //Devam etmek istiyor musunuz?E
            //3
            //Devam etmek istiyor musunuz?H
            //Girilen sayıların en büyüğü:10


            //int max = int.MinValue, toplam = 0;

            //for (; ; )
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }

            //    if (sayi % 2 == 0)
            //    {
            //        toplam += sayi;
            //    }
            //    Console.WriteLine("Devam etmek istiyor musunuz?(e/h)");
            //    char cevap = char.Parse(Console.ReadLine());
            //    if (cevap == 'h')
            //    {
            //        Console.WriteLine($"Girilen en büyük sayı:{max}\nGirilen Çift sayıların toplamı:{toplam}");
            //        break;
            //    }
            //}

            //while (1 == 1)
            //{
            //    Console.WriteLine("Gazi");
            //}


            //for (int i = 0; i < 3; i++)
            //{

            //}


            //int sayac = 0;
            //while (sayac < 5)
            //{
            //    sayac++;
            //}


            //var rnd = new Random();
            //int sayi = rnd.Next(100);
            ////Console.WriteLine(sayi);
            //int sayac = 0;
            //while (sayac < 3)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int number = int.Parse(Console.ReadLine());
            //    if (number == sayi)
            //    {
            //        Console.WriteLine("Tebrikler bildiniz!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bilemediniz..Tekrar deneyiniz..");
            //    }
            //    sayac++;
            //}


            //var rnd = new Random();
            //int random = rnd.Next(100);
            //int sayac = 0;
            //do
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int number = int.Parse(Console.ReadLine());
            //    if (number == random)
            //    {
            //        Console.WriteLine("Tebrikler bildiniz!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bilemediniz..Tekrar deneyiniz..");
            //    }
            //    sayac++;
            //} while (sayac < 3);


            //Bir sayı giriniz:5
            //Devam/Tamam:d
            //Bir sayı giriniz:10
            //Devan/Tamam:t
            //Girilen sayıların toplamı:15

            //int toplam = 0;
            //char cevap;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam = toplam + sayi;
            //    Console.WriteLine("Tamam/Devam?");
            //    cevap = char.Parse(Console.ReadLine());
            //} while (cevap == 'd');

            //Console.WriteLine($"Girilen sayıların toplamı:{toplam}");

            
        }
    }
}
//i:Döngü değişkeni (iteration)