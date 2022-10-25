using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICrediManager crediManager = new ICrediManager();
            //Hatalı. Interfacelerden new ile nesne oluşturulamaz. Şu şekilde yapılmalıdır

            //ReferansTip ile tanımlı olduğu için bu şekilde yapabildik. Aynı kalıtımdaki gibi
            ICrediManager carCrediManager = new CarCrediManager();
            carCrediManager.Calculate();

            ICrediManager houseCrediManager = new HouseCrediManager();
            houseCrediManager.Calculate();

            ICrediManager reqCrediManager = new ReqCrediManager();
            reqCrediManager.Calculate();

            Console.WriteLine("******************************");
            Console.WriteLine(" ");

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(houseCrediManager);
            basvuruManager.BasvuruYap(carCrediManager);
            
            Console.WriteLine("******************************");
            Console.WriteLine(" ");

            List<ICrediManager> credies = new List<ICrediManager>() { carCrediManager, reqCrediManager };
            //Kaç tane istiyorsak o kadar göndericez. Mesela araba ve ev kredisi bilgisi istiyoruz. Listeye ikisini göndeririz
            basvuruManager.CrediInfo(credies);

            Console.WriteLine("******************************");
            Console.WriteLine(" ");
            ILog dataLog = new DatabaseLogManager();
            ILog smsLog = new SmsLogManager();

            basvuruManager.BasvuruYap(houseCrediManager,dataLog);
            basvuruManager.BasvuruYap(carCrediManager,smsLog);


        }
    }
}
