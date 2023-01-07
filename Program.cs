namespace EmployeeWageNonStatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeWage obj = new EmployeeWage();


            obj.addCompanies("deloite", 10, 15, 90);

            obj.addCompanies("Dell", 35, 20, 100);
            obj.computeWage();

        }
    }
}
