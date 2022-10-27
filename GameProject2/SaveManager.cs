using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class SaveManager : ISaveServices
    {
        IEStateValidation _eStateValidation;

        public SaveManager(IEStateValidation eStateValidation)
        {
            _eStateValidation = eStateValidation;
        }

        public void Add(Gamers gamer)
        {
            if (_eStateValidation.Validation(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu Doğrulandı ve");
                Console.WriteLine(gamer.FirstName + " adlı oyuncu kaydedildi");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu doğrulanamadı. Kayıt başarısız");
            }
        }

        public void Delete(Gamers gamer)
        {
            if (_eStateValidation.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu Doğrulandı ve");
                Console.WriteLine(gamer.FirstName + " adlı oyuncu silindi");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu doğrulanamadı. Silme başarısız");
            }
        }

        public void Update(Gamers gamer)
        {
            if (_eStateValidation.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu Doğrulandı ve");
                Console.WriteLine(gamer.FirstName + " adlı oyuncu güncellendi");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu doğrulanamadı. Güncelleme başarısız");
            }
        }
    }
}
