using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameManager : IGameService
    {

        public void AddGame(Game game)
        {
            Console.WriteLine("Game added.");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine("Game deleted.");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine("Game updated.");
        }
    }
}
