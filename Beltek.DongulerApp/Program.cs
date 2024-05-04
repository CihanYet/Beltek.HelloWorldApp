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



            Console.WriteLine("Başlangıç değeri giriniz:");
            byte bas = byte.Parse(Console.ReadLine());

            Console.WriteLine("Bitiş değeri giriniz:");
            byte bit = byte.Parse(Console.ReadLine());
            int sonuc = 0;

            //bas:10
            //bit:5

            if (bas>bit)
            {
                byte temp = bas;
                bas = bit;
                bit = temp;
            }

            for (int i = bas; i < bit; i++)
            {
                //sonuc = sonuc + i;
                sonuc += i;
                Console.WriteLine(i);
            }



            Console.WriteLine($"İşlemin sonucu:{sonuc}");

            //3-4-5
            //int sonuc = 0;
            //sonuc = sonuc + 3;
            //sonuc = sonuc + 4;
            //sonuc = sonuc + 5;
            //Console.WriteLine(sonuc);



        }
    }
}
//i:Döngü değişkeni (iteration)