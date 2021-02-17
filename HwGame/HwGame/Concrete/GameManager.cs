using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    public class GameManager : ISystemService
    {
        public void Add(Platform game)
        {
            Console.WriteLine(game.GameName + " added");
        }

        public void Delete(Platform game)
        {
            Console.WriteLine(game.GameName + " deleted");
        }

        public void Update(Platform game)
        {
            Console.WriteLine(game.GameName + " updated");
        }
    }
}
