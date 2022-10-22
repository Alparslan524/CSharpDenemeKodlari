using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler = new List<string> {"Alp","Arslan","Kasım" };
            foreach (var name in isimler)
            {
                Console.WriteLine(name);
            }
            isimler.Add("Murat");
            Console.WriteLine(isimler[3]);
        }
    }
}
