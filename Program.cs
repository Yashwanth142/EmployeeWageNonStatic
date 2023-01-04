namespace EmployeeWageNonStatic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            employeeWage obj = new employeeWage("deloitte", 20, 20, 80);
            obj.Cal_Wage();
            Console.WriteLine(obj.toString());

            employeeWage obj1 = new employeeWage("adobe", 25, 10, 90);
            obj1.Cal_Wage();
            Console.WriteLine(obj1.toString());


        }
    }
}