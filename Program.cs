namespace EmployeeWageNonStatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            employeeWageCompanyArray obj = new employeeWageCompanyArray();


            obj.addCompanies("deloitte", 20, 15, 90);

            obj.addCompanies("adobe", 25, 10, 80);
            obj.computeWage();

        }
    }
}