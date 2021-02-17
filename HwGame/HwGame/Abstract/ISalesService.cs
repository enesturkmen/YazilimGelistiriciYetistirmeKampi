using HwGame.Concrete;
using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Abstract
{
    interface ISalesService
    {
        void Sale(Platform game);
        void Sold(Platform gamer);
        
    }
}
