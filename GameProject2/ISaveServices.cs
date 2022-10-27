using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    interface ISaveServices
    {
        void Add(Gamers gamer);
        void Delete(Gamers gamer);
        void Update(Gamers gamer);

    }
}
