namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Tam sayılar
           // int id = 12;
            //int değişken türü tamsayı değeri tutar.
            //4 bayt 
            //id = 4;
            //Console.WriteLine(id);
            byte a = 5;// 1 bayt 
            short b = 6;//2 bayt
            long c = 7; // 8 byte
            ulong d = 8; // 8 byte
          //değişken türü değişken adı. 
            //Reel sayı degerleri alabiliyor.
            float f = 5.2f; //4 byte reel sayı
            double g = 10.2d; //8 byte reel sayı
            decimal h = 5.23M;  //16 byte reel sayı

            // alt çizği _
            int ogrenci_no = 10;
            //boşluk - tire ' tırnak içermemeli
            int Id = 10;
            int id = 20;

            //başta tarfada rakam içermemlidir.
            // string 10numara = "dasdcds";
            // string numara10 = "dnsjc";
            string Ramazan = "Ramazan KÜÇÜKKOÇ";
            //sınırsız boyutta

            //Derleyici tarfından tanımlanıyor.
            var ramazan = "xacd";

            //bool iki değer(value) alabiliyor True- False
            //bool dogru = true;
            //Console.WriteLine(dogru);
            //bool yanlis = false;
            //int sayi = 5;
            //bool sonuc = sayi > 10;

            //Console.WriteLine(dogru);
            //Console.WriteLine(yanlis);
            //Console.WriteLine(sonuc);

            //object veri tipi

            object ramo = "Ramo";
            object o2 = 12.5f;
            object o3 = 'c';
            object o4 = true;

            object b1 = 10; //boxing
            //unboxing
            int a1 = (int)b1;
            Console.WriteLine(a1);

            object adim = "Ahmet";
            string adim1 =(string)adim;
            Console.WriteLine(adim1);
        }
    }
}