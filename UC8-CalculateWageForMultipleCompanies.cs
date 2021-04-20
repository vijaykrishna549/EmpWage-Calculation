using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyWageCalculation
{
    class UC8_CalculateWageForMultipleCompanies
    {
        class UC8_ComputeEmpWageForMultipleCompanies
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {

                //variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;
                while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
                }
                int totalEmpWage = totalEmpHrs * empRatePerHour;
                Console.WriteLine("Total Emp Wage for company: " + company + " is : " + totalEmpWage);
                return totalEmpWage;
            }

            //static void Main(String[] args)
            //{
            //    ComputeEmpWage("DMart",20,2,10);
            //    ComputeEmpWage("Reliance",10,4,20);
            //}

        }







        static void Main(string[] args)
        {
            //UC3_PartTimeEmpWage.PartTimeEmpWage();
            //UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            //UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            //UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            //UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            //UC8 starts
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("DMart", 20, 2, 10);
            //UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("Reliance", 10, 4, 20);
            //UC8 Ends

            Console.ReadKey();


        }
    }
}