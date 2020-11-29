using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrencimisin?   (e/h)" );
            string yanıt = Console.ReadLine();
            if (yanıt=="e")
            {
                musteri ogrenci = new musteri();
                ogrenci.ad = "Kağan";
                ogrenci.soyad = "Ayyıldız";
                ogrenci.ogr_no = 221903510;
                ogrenci.yas = 20;

                Console.WriteLine(ogrenci.ad);

            }
            else if (yanıt == "h")
            {
                musteri müsteri = new musteri();
                müsteri.ad = "Eda";
                müsteri.soyad = "Pınar";
                müsteri.yas = 36;
                müsteri.meslek = "Software developer";
                müsteri.maas = 8850;
            }
        }
    }
}
