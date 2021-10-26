using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DortIslem matematikislemi = new DortIslem();
            matematikislemi.Topla(6, 2);

            matematikislemi.Topla(78, 12);
        }
    }
}
