using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Abstract
{
    interface IGameService
    {
        void Add(Games gamer);
        void Delete(Games gamer);
        void Update(Games gamer);
    }
}
