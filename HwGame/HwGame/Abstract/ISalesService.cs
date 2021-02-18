using HwGame.Concrete;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Abstract
{
    interface ISalesService
    {
        void Sale(Games sale);
        void Sold(Gamers sold, Games game);
        
    }
}
