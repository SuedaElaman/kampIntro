using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "EKerem varış";
            kurs2.izlenmeOrani = 65;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.izlenmeOrani = 80;

            //for each var
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }


    }

}

        