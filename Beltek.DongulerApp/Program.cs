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

            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine($"İşlemin sonucu:{sonuc}");


            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;

            ////8
            ////2 3 4 5 6 7 

            //for (int i = 2; i <= sayi/2; i++)
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


            int max = int.MinValue, toplam = 0;

            for (; ; )
            {
                Console.WriteLine("Sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi > max)
                {
                    max = sayi;
                }

                if (sayi % 2 == 0)
                {
                    toplam += sayi;
                }
                Console.WriteLine("Devam etmek istiyor musunuz?(e/h)");
                char cevap = char.Parse(Console.ReadLine());
                if (cevap == 'h')
                {
                    Console.WriteLine($"Girilen en büyük sayı:{max}\nGirilen Çift sayıların toplamı:{toplam}");
                    break;
                }
            }
            //5*4*3*2
        }
    }
}
//i:Döngü değişkeni (iteration)