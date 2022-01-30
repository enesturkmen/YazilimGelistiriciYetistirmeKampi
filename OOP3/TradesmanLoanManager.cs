using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tradesman loan calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
