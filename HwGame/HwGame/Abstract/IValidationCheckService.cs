using HwGame.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HwGame.Abstract
{
    interface IValidationCheckService
    {
        bool Validate(Gamers gamer);
    }
}
