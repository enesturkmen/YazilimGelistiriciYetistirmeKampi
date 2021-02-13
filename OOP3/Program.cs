using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanManager personalFinanceLoan = new PersonalFinanceLoan();
            ILoanManager vehicleLoanManager = new VehicleLoanManager();
            ILoanManager housingLoanManager = new HousingLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            //veya 22. satir virgulden sonrasi gibi de yazabilirsin
            ILoggerService fileLoggerService = new FileLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.MakeRecourse(personalFinanceLoan, fileLoggerService);

            List<ILoanManager> loans = new List<ILoanManager>() {personalFinanceLoan, 
                vehicleLoanManager };

            //recourseManager.PreLoanInfo(loans);
        }
    }
}
