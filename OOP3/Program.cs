using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TaşıtKrediManager taşıtKrediManager = new TaşıtKrediManager();
            //taşıtKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,taşıtKrediManager,konutKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);







        }
    }
}
