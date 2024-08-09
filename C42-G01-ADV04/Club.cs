using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV04
{

    internal class Club
    {        
        public int ClubID { get; set; }
        public string ClubName { get; set; }
                
        public List<Employee> Members = new List<Employee>();
                
        public void AddMember(Employee employee)
        {
            if (employee != null)
            {
                Members.Add(employee);
                // Register for the EmployeeLayOff event
                employee.EmployeeLayOff += RemoveMember;
            }
        }

        // Callback method to remove an employee from the club's member list
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e) // Again not accepting Employee, it must be object??? why ???
        {
            Employee employee = (Employee)sender;
            if (employee != null)
            {                
                if (e.Cause == LayOffCause.VacationStockNegative)
                {
                    Members.Remove(employee);
                    Console.WriteLine($"Employee ID {employee.EmployeeID} removed from Club {ClubName} due to: {e.Cause}");
                }
                else
                {
                    Console.WriteLine($"Employee ID {employee.EmployeeID} remains in Club {ClubName} despite layoff due to: {e.Cause}");
                }
            }
        }
        
    }
}
