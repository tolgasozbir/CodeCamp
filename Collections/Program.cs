using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler1 = new List<string>();
            isimler1.Add("Tolga");
            isimler1.Add("Levent");
            Console.WriteLine(isimler1[0]);
            Console.WriteLine(isimler1[1]);

            Console.WriteLine("-----------");

            List<string> isimler2 = new List<string> { "Tolga", "Levent" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("Bülent");
            Console.WriteLine(isimler2[2]);


            Console.WriteLine("-----------");
            foreach (var item in isimler2)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
