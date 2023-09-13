namespace KontrolYapıilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int sayi = 9;
            ////IF-ELSE Kontrol yapılarında kullanılıyor diyebiliriz.
            //// is ==
            ////is not  !=

            //if (sayi is not 10)
            //{
            //    sayi++;
            //    sayi--;

            //    Console.WriteLine($"{sayi} numara sayı");
            //}
            //else
            //{
            //    Console.WriteLine("Sayımız 10 sayısına eşit değildir.");
            //}

            //koşul ifadesi? ilk ifade :ikinci ifade

            //ternary ifadesi denebiliyor.
            //int sayi1 = 25;

            //if (sayi1 % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifftir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tekttir");
            //}


            //int sayi2 = 24;
            //string sonuc = (sayi2 % 2 == 0) ? "Sayı çifttir" : "Sayı Tekttir";
            //Console.WriteLine(sonuc);



            int x, secim;
            double kare, kok, kup;
            Console.Write("Bir sayı giriniz =");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("1-kare 2-Küp 3-Kök \n");
            Console.WriteLine();

            Console.WriteLine("Seçiminiz");
            secim=int.Parse(Console.ReadLine());

            if (secim ==1)
            {
                kare = x * x;
                Console.Write("Girdiğiniz sayının karesi= {0}", kare,secim);

            }
            else if (secim ==2)
            {
                kup = x * x * x;
                Console.Write("Girdiğiniz sayının küpü= {0}", kup);
            }
            else if (secim ==3)
            {
                kok = Math.Sqrt(x);
                Console.Write("Girdiğiniz sayının kökü ={0}", kok);        
            }




            Console.ReadKey();
        }
    }
}