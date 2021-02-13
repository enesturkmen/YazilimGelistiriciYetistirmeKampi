using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RecourseManager
    {
        public void MakeRecourse(ILoanManager loanManager, ILoggerService loggerService)
        {
            loanManager.Calculate();
            loggerService.LoggerService();

        }
        public void PreLoanInfo(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
