namespace EmployeeWageNonStatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWage obj = new EmployeeWage();
            obj.Cal_Wage("Deloitte", 20, 15, 80);
            obj.Cal_Wage("Adobe", 25, 10, 60);

        }
    }
}