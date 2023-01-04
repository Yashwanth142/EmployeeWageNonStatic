namespace EmployeeWageNonStatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWage Refactor = new EmployeeWage();
            Refactor.Cal_Wage();

        }
    }
}