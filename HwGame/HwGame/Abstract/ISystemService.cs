using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Abstract
{
    interface ISystemService
    {
        void Add(Platform manager);
        void Delete(Platform manager);
        void Update(Platform manager);

    }
}
