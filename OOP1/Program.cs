using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Topla2(6, 2);
            productManager.Topla(6, 3);
            int toplamSonucu = productManager.Topla(6, 3);
            
            //Console.WriteLine(productManager.Topla(6,3)*2);
            Console.WriteLine(toplamSonucu*2);

        }
    }
}
