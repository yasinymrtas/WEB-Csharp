using System;

namespace WEB_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string kullanıcı_secenegi = "kategoriler";

            int tamsayi = 3000000;

            double ondalikli_sayi = 1.62;

            bool sisteme_giris_yapıldı_mi = false;

            double dolardün = 7.65;
            double dolarbugün = 7.96;

            if(dolardün>dolarbugün)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarbugün>dolardün)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sisteme_giris_yapıldı_mi==true)
            {
                Console.WriteLine("Kullanıcı ayarları");
            }
            if(sisteme_giris_yapıldı_mi==false)
            {
                Console.WriteLine("giriş yapınız");
            }

            Console.WriteLine(ondalikli_sayi);
            Console.WriteLine(kullanıcı_secenegi);
            Console.WriteLine(tamsayi);
         
        }
    }
}
