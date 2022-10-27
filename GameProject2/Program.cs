using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamers gamer = new Gamers { TcNo = 6610, BirthDay = "2002", FirstName = "Alparslan", LastName = "Aydoğan" };
            EStateValidation eStateValidation = new EStateValidation();
            SaveManager saveManager = new SaveManager(eStateValidation);//Doğrulaam türünü gönderdik.
            saveManager.Add(gamer);                                     //Farklı bir doğrulama türü olsaydı onu gönderecektik

            Gamers gamer1 = new Gamers { TcNo = 6642, BirthDay = "2000", FirstName = "Rabia", LastName = "Aydoğan" };
            EStateValidation eStateValidation1 = new EStateValidation();//Farklı doğrulama türünü seçebilirdik mesela
            SaveManager saveManager2 = new SaveManager(eStateValidation1);
            saveManager2.Add(gamer1);
        }
    }
}
