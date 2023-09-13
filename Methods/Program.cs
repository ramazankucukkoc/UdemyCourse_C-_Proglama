namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Sayıyı Giriniz");
            //short x = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(KaresiniBul(x));
            //Hesapla();
            //UcgenAlan();
            //Console.WriteLine("A degeri gir =");
            //double a =Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("H degeri gir =");
            //double h = Convert.ToDouble(Console.ReadLine());
            //UcgenAlan(a, h);
            //Console.WriteLine("Kenarı Giriniz =");
            //int kenar = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Kare(kenar));

            Console.WriteLine("Adınızı Giriniz =");
            string isim1 =Console.ReadLine();

            Console.WriteLine("Soyadınızı Giriniz =");
            string soyisim = Console.ReadLine();
            string sonuc1 = isim_soyad(isim1, soyisim);
            Console.WriteLine(sonuc1);



            Console.WriteLine("İkinci Adınızı Giriniz =");
            string isim2 = Console.ReadLine();
            string sonuc2 = isim_soyad(isim1, soyisim, isim2);
            Console.WriteLine(sonuc2);

            Console.ReadLine();



        }
        //overloading(aşırı yükleme)
        static string isim_soyad(string isim1,string soyisim)
        {
            string sonuc = isim1 + " " + soyisim;
            return sonuc;
        }
        static string isim_soyad(string isim1,string soyisim,string isim2)
        {
            string sonuc =isim1 +" "+ isim2 + " "+soyisim;
            return sonuc;
        }


        //Geriye değer döndüren ve paremetre alan metotlar
        static int Kare (int kenar)
        {
            int alan = kenar * kenar;
            return alan;
        }

        //geriye değer döndüren ve paremetresiz metotlar
        //static double Kare()
        //{
        //    Console.Write("Karenin kenarını giriniz =");
        //    double kenar =Convert.ToDouble(Console.ReadLine());
        //   // double alan = kenar * kenar;
        //    double cevre = kenar * 4;

        //    return  cevre ;

        //}



        //değer döndürmeyen ve paremetreli metot tanımlaması
        static void  UcgenAlan(double a ,double h)
        {
            double alan = (a * h) / 2;
            Console.WriteLine("Alanı ={0}", alan);
        }



        //deger döndürmeyen void anahtar kelimesi unutulmamalıdır.
        //static void UcgenAlan()
        //{
        //    Console.Write("A degerini Giriniz =");
        //    double a =Convert.ToDouble(Console.ReadLine());
        //    Console.Write("H degerini Giriniz =");
        //    double h = Convert.ToDouble(Console.ReadLine());
        //    double alan = (a * h) / 2;
        //    Console.WriteLine("Üçgenin alanı Hesaplandı ="+alan);
        //}


        // erişim biçimi geri dönüs tipi Metot ismi(Paremetre)
        //{  kodlarımız yer alıyor. }
        //static int KaresiniBul(short x)
        //{
        //    return x*x;
        //}

        //static void Hesapla()
        //{
        //    Console.Write("Kısa Kenarı Giriniz");
        //    int kisaKenar = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Uzun Kenarı Giriniz");
        //    int uzunKenar = Convert.ToInt32(Console.ReadLine());
        //    int alan = kisaKenar * uzunKenar;
        //    int cevre = (kisaKenar + uzunKenar) * 2;
        //    Console.WriteLine("Alan ={0} Çevre ={1}",alan, cevre);
        //}

        //tekrar tekrar aynı kodları kullanılması gereken yerlerde çagırılıp
        //kodlarımız temiz uzun olmaması kullanıyoruz diyebiliriz.

    }
}