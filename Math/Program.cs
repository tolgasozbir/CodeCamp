using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(3, 5);
            dortIslem.Topla(12, 75);
            Console.ReadKey();
        }
    }
}
