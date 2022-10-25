using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    public class SmsLogManager : ILog
    {
        public void Logging()
        {
            Console.WriteLine("SMS olarak loglandı");
        }
    }
}
