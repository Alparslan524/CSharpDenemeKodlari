using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    public class EStateValidation : IEStateValidation
    {
        public bool Validation(Gamers gamer)
        {
            if (gamer.TcNo==6610)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
