namespace Beltek.MetodlarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dört işlem örneği
            //Console.WriteLine("1.sayıyı giriniz:");
            //double s1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz:");
            //double s2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("İşlem seçiniz:\n1-Toplama\n2-Çarpma\n3-Bölme\n4-Çıkarma");
            //byte secim = byte.Parse(Console.ReadLine());

            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine($"Toplama işleminin sonucu:{Topla(s1, s2)}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Çarpma işleminin sonucu:{Carp(s1, s2)}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Bölme işleminin sonucu:{Bol(s1, s2)}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"Çıkarma işleminin sonucu:{Cikarma(s1, s2)}");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı işlem seçimi..");
            //        break;
            //} 
            #endregion

            Console.WriteLine("Taban değeri giriniz:");
            double taban = double.Parse(Console.ReadLine());
            Console.WriteLine("Us değeri giriniz:");
            double us = double.Parse(Console.ReadLine());
            Console.WriteLine($"İşlemin sonucu:{UsluSayi(taban, us)}");
            Math.Pow(taban, us);
        }

        /// <summary>
        /// İki sayıyı toplayan metod
        /// </summary>
        /// <param name="sayi1">Toplanacak 1. sayı</param>
        /// <param name="sayi2">Toplanacak 2. sayı</param>
        /// <returns>integer</returns>
        static double Topla(double sayi1, double sayi2)//double,double
        {
            return sayi1 + sayi2;
        }

        static double Topla(double sayi1, double sayi2, double sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        static double Topla(int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    toplam += sayilar[i];
            //}
            return toplam;
        }

        static double Cikarma(double sayi1, double sayi2) => sayi1 - sayi2;

        static double Carp(double sayi1, double sayi2) => sayi1 * sayi2;

        static double Bol(double sayi1, double sayi2) => sayi1 / sayi2;


        static double UsluSayi(double taban, double us)
        {
            double sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }


    }
}

//Method Signature-Metod İmzası: Metod parametrelerinin sayıları ve veri tipleri, metod imzasını oluşturur.

//Method Overloading: Aynı isimli metodların farklı imzalarla tanımlanması işlemi.