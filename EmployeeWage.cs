using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageNonStatic
{
    class EmployeeWage
    {

        private Array[] CompanywageArray;
        private int noOfCompany = 0;
        public EmployeeWage()
        {
            this.CompanywageArray = new Array[5];
        }
        public void addCompanies(string Company, int wagePerHour, int maxdays, int maxhours)
        {
            CompanywageArray[noOfCompany] = new Array(Company, wagePerHour, maxdays, maxhours);
            noOfCompany++;
        }

        public void computeWage()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                CompanywageArray[i].setEmpWage(computeWage(CompanywageArray[i]));
                Console.WriteLine(CompanywageArray[i].toString());

            }
        }


        private int computeWage(Array array)
        {
            Console.WriteLine("\n Program for Calculating {0} Employee Wage !!\n", array.Company);

            int workingHours = 8;

            int emphours = 0;
            int days = 1;
            int Totalwork = 0;
            


            while ((emphours <= array.maxhours) && (days <= array.maxdays))
            {
                Random random = new Random();
                int atten = random.Next(3);


                if (atten == 1)
                {
                    Totalwork = array.wagePerHour * 8;
                    workingHours = 8;
                }
                else if (atten == 2)
                {
                    Totalwork = array.wagePerHour * 4;
                    workingHours = 4;
                }
                else
                {
                    Totalwork = 0;
                    workingHours = 0;
                }
                emphours += workingHours;

                if (emphours <= array.maxhours)
                {
                    array.Monthwork += Totalwork;
                    Console.WriteLine("day::{0} employee_hour::{1} empwage : {2}", days, emphours, Totalwork);
                }
                days++;
            }
            return array.Monthwork;
        }

    }

}
