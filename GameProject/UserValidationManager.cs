using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.UserName == "ENES" && gamer.LastName == "TUERKMEN" && gamer.BirthYear == 1997 && gamer.IdentityNumber == 12345678910)
            {
                return true;
            }
            else
                return false;
        }
    }
}
