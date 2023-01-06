namespace EmployeeWageNonStatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeWage obj = new EmployeeWage();


            obj.addCompanies("deloitte", 20, 15, 90);

            obj.addCompanies("adobe", 25, 10, 80);
            obj.computeWage();

        }
    }
}