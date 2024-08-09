using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV04
{
    internal class Employee
    {
        // Fields & Properties
        public int EmployeeID { get; set; }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private int vacationStock;
        public int VacationStock
        {
            get { return vacationStock; }
            set { vacationStock = value; }
        }

        // Methods
        // To calculate age and vacation days
        public int CheckAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;

            return age;
        }

        public bool RequestVacation(DateTime from, DateTime to)
        {            
            int daysRequested = to.Day - from.Day;
                        
            if (VacationStock >= daysRequested)
            {                
                VacationStock -= daysRequested;
                return true; // Vacation approved
            }
            else
            {
                return false; // Vacation rejected
            }
        }

        public void EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
            }
            else if (CheckAge() > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeOver60 });
            }
        }


        public event /*delegate*/ EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff; // only single parameter
        // EventHandler ده عبارة عن ايه بالضبط
        // EventHandler is a built-in keyword not a custom made delegate
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e); // Must be two parameters, why???
            // The IDE is forcing me to write it like this although I did not specify two parameters in the delegate
        }

    }
}
