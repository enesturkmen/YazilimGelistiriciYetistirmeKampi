using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    class UserValidationManager : IValidationCheckService
    {
        public bool Validate(Gamers gamer)
        {
            if(gamer.YearOfBirth == 1997 && gamer.GamerFirstName == "ENES" 
                && gamer.GamerLastName == "TURKMEN" && gamer.GamerTcNo == 12345678901)
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
