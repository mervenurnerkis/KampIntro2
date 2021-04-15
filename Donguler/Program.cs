using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new[] { "Yazılım geliştirme kampı", 
                "Programlamaya başlangıç için temel kurs", "java" };
               

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            //foreach dizilere uygulanır.dizileri tek tek dolaşmaya yarar.dizileri kolay dolaşırız.
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
          
        }
    }
}
