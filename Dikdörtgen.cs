using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (0 == 0)
            {
                
                
            
            Console.WriteLine("Alan Hesaplamak İçin 1'e Çevre Hesaplamak İçin 2'ye Programdan çıkmak için 3'e Basın?");
            int sec = Convert.ToInt32(Console.ReadLine());

            Dikdörtgen dikdörtgen = new Dikdörtgen();

            if (sec == 1)
            {
                Console.WriteLine("Yüksekliği ve uzunluğu Giriniz");
                dikdörtgen.b = Convert.ToInt32(Console.ReadLine());
                dikdörtgen.h = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Dikdörtgenin Alanı => " + alanhesapla(dikdörtgen.b, dikdörtgen.h));
            }

            else if (sec == 2)
            {
                Console.WriteLine("Yüksekliği ve uzunluğu Giriniz");
                dikdörtgen.b = Convert.ToInt32(Console.ReadLine());
                dikdörtgen.h = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Dikdörtgenin Çevresi => " + cevrehesapla(dikdörtgen.b, dikdörtgen.h));
            }
            else if (sec == 3)
            {
                break;
            }

            }

            static int alanhesapla(int b, int h)
            {
                return b * h;
            }

            static int cevrehesapla(int b, int h)
            {
                int c = 2 * b + 2 * h;
                return c;
            }

        }
    }

    class Dikdörtgen
    {
        public int b { get; set; }
        public int h { get; set; }
    }

    
}
