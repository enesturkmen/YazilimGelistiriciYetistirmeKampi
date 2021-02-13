using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi odeme plani hesaplandi.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
