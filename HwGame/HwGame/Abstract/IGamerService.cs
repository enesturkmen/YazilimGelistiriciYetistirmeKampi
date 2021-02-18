using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Abstract
{
    interface IGamerService
    {
        void Add(Gamers gamer);
        void Delete(Gamers gamer);
        void Update(Gamers gamer);

    }
}
