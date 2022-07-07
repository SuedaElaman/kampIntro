using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için kurs";
            string kurs3 = "java";


            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", "Programlamaya başlangıç için kurs", "java" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("sayfa sonu");


        
    }
    }
}
