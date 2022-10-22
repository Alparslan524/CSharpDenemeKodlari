using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Alp");
            isimler.Add("Arslan");
            isimler.Add("Aydoğan");

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }


        }
    }
}
