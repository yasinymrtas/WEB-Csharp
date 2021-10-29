using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yasin Yumrutaş
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "3153151";
            musteri1.Adi = "Yasin";
            musteri1.Soyadi = "Yumrutaş";
            musteri1.TcNo = "2222222222222222";

            //Mr.Tech
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "684531";
            musteri2.SirketAdi = "Mr.Tech";
            musteri2.Id = 2;
            musteri2.VergiNo = "481531";



            //new - referans almak içindi bir nevi adres tanımlamak için

            Musteri musteri3 = new TuzelMusteri();
            Musteri musteri4 = new GercekMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

                


        }
    }
}
