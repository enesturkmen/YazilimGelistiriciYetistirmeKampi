using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    class GameSaleManager : ISalesService
    {
        public void Sale(Platform game)
        {
            Console.WriteLine(game.GameName + " on sale!");
        }

        public void Sold(Platform gamer)
        {
            Console.WriteLine(gamer.GamerName + " bought " + gamer.GameName);
        }
    }
}
