using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void Biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi planlaması hesaplandı");
        }
    }
}
