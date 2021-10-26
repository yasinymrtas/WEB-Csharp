using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();

            kurs1.IzlenmeOrani = 90;
            kurs1.KullaniciAdi = "Yasin Yumrutaş";
            kurs1.KursAdi = "C# WEB";


            Kurs kurs2 = new Kurs();

            kurs2.IzlenmeOrani = 60;
            kurs2.KullaniciAdi = "Enver Yumrutaş";
            kurs2.KursAdi = "go";

            Kurs kurs3 = new Kurs();

            kurs3.IzlenmeOrani = 70;
            kurs3.KullaniciAdi = "Hacer Yumrutaş";
            kurs3.KursAdi = "İngilizce";

            Kurs kurs4 = new Kurs();

            kurs4.IzlenmeOrani = 90;
            kurs4.KullaniciAdi = "İsmail Yumrutaş";
            kurs4.KursAdi = "Pasta";


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (Kurs x in kurslar)
            {
                Console.WriteLine(x.KursAdi + " : " + x.KullaniciAdi + " : " + x.IzlenmeOrani);
            }
        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KullaniciAdi { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}

