using HwGame.Abstract;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Concrete
{
    public class GamerManager : ISystemService
    {
        public void Add(Platform gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " added");
        }

        public void Delete(Platform gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " deleted");
        }

        public void Update(Platform gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " updated");
        }
    }
}
