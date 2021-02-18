using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    class GameSaleManager : ISalesService
    {
        IGameService _gameService;

        public GameSaleManager(IGameService gameService)
        {
            _gameService = gameService;
        }

        public void Sale(Games game)
        {
            
            Console.WriteLine(game.GameName + " on sale!");
        }

        public void Sold(Gamers gamer, Games game)
        {
            Console.WriteLine(gamer.GamerFirstName + " bought " + game.GameName);
        }
    }
}
