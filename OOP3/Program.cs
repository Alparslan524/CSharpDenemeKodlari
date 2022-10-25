using System;

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

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(houseCrediManager);
            basvuruManager.BasvuruYap(carCrediManager);

        }
    }
}
