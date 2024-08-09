namespace C42_G01_ADV04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new employee
            Employee employee = new Employee { EmployeeID = 123, BirthDate = new DateTime(1960, 8, 9), VacationStock = 10 };
            
            employee.EndOfYearOperation();
        }

        

    }
}

