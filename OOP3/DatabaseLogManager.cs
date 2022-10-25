using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class DatabaseLogManager : ILog
    {
        public void Logging()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
