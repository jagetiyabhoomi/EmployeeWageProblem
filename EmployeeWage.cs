using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {/// <summary>
    /// Calculating Wages of Employees
    /// </summary>
        public static void CalEmployeeWage()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int Wage = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);


            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Full Time");
                empHrs = 8;
            }
            
            else
            {
                Console.WriteLine("Employess hasn't worked");
                empHrs = 0;
            }

            empWage = empHrs * Wage;
            Console.WriteLine("Employee Wage is: " + empWage);
        }
    }
}
