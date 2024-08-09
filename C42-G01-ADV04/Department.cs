using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV04
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
                
        public List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee employee)
        {
            if (employee != null)
            {
                Staff.Add(employee);
                // Register for the EmployeeLayOff event
                employee.EmployeeLayOff += RemoveStaff;
            }
        }

        // Callback method to remove an employee from the staff list
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e) // why object, why not employee directly
        {            
            Employee employee = (Employee)sender;
            if (employee != null)
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee ID {employee.EmployeeID} removed from Department {DeptName} due to: {e.Cause}");
            }
        }        
        
    }
}
