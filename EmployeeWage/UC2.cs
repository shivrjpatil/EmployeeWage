using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWages
{
    public class UC2
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8;
        Random random = new Random();
        public void Attendance()
        {
            int check = random.Next(0, 2);
            if (check == 0)
                Console.WriteLine("Employee is Present.");
            else
                Console.WriteLine("Employee is absent");
        }

        public void WageCal()
        {
            int salary = 0;
            int check = random.Next(0, 2);
            if (check == 0)
                salary = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine("Wage of the Employee is : " + salary);
        }
    }
}