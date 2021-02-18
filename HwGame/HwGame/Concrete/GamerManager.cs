using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    class GamerManager : IGamerService
    {
        IValidationCheckService _iValidationCheckService;

        public GamerManager(IValidationCheckService iValidationCheckService)
        {
            _iValidationCheckService = iValidationCheckService;
        }

        public void Add(Gamers gamer)
        {
            if (_iValidationCheckService.Validate(gamer))
            {
                Console.WriteLine(gamer.GamerFirstName + " added");
            }
            else
            {
                Console.WriteLine("Validate failed!");
            }
           
        }

        public void Delete(Gamers gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " deleted");
        }

        public void Update(Gamers gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " updated");
        }
    }
}
