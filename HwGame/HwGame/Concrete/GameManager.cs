using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Games game)
        {
            Console.WriteLine(game.GameName + " added");
        }

        public void Delete(Games game)
        {
            Console.WriteLine(game.GameName + " deleted");
        }

        public void Update(Games game)
        {
            Console.WriteLine(game.GameName + " updated");
        }
    }
}
