using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class SwitchCase
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int PER_HR_WAGE = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public static void SolutionUsingSwitchCase()
        {

            int empHrs = 0;
            int empWage = 0;
            int totalemphrs = 0;
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                Console.WriteLine("Day{0} -> {1}Hours Worked",i,empHrs);
                totalemphrs += empHrs;
            }
            empWage = totalemphrs * PER_HR_WAGE;
            Console.WriteLine("Employee Total Wage is: " + empWage);
        }
    }
}