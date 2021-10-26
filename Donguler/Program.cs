using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılı geliştirme kampı", "programlama eğitimi", "Enes Bayram C# eğitimi",
                "Abimin içinden geçiş eğitimi " };
            
            for (int i=0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine(kurslar.Length);
            Console.WriteLine("kurslar bitti");

            
        }
    }
}
