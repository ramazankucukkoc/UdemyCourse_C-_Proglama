namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //temel atama operatörü
            //double x = 1.2;
            ////aritmetik operatörler
            //// + ,- ,* ,/, % 
            ////16 % 3 = 1 

            //Console.WriteLine("Sayı Giriniz");
            //int sayi1 =Convert.ToInt32(Console.ReadLine());
            //int sonuc = sayi1 % 2;
            //Console.WriteLine("Kalan sayı = "+sonuc);
            ////  Console.WriteLine("Kalan sayı = {0}",sonuc);

            //ilişkisel operatörler
            // == , > ,<,>=,<= ,!=

            //mantıksal operatörler 
            // && ,|| ,

            //tekli operatörler
            // ++, --, !
            // += ,-=,*=,%=,
            bool sonuc1;
            int ilkSayi = 10;
            int ikinciSayi = 30;
            if (ilkSayi ==ikinciSayi)
            {
                ilkSayi+=ikinciSayi;
            Console.WriteLine("Sayılar biribirine eşittir.");

            }
            else if (ilkSayi !=ikinciSayi || ilkSayi>0)
            {
                ikinciSayi -= ilkSayi;
                Console.WriteLine("Sayılar biribirine eşit değildir.");
                if (ilkSayi>ikinciSayi )
                {
                    Console.WriteLine("İlk sayı büyüktür.");

                }               
                else
                {
                    Console.WriteLine("İkinci sayı büyüktür.");

                }
            }
            else
            {
                Console.WriteLine("Yukarıdaki degerleri saglamıyor.");
            }
            Console.WriteLine(ikinciSayi);
            Console.WriteLine(ilkSayi);


            Console.ReadKey();


        }
    }
}