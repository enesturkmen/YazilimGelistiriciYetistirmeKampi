using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
     class GamerManager : IGamerService

    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.UserName + " gamer added!");
            }
            else
            {
                Console.WriteLine("Registration failed because validation failed!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " gamer updated!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " gamer deleted!");
        }
    }
}
