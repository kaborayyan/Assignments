using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_ADV04
{
    internal class EmployeeLayOffEventArgs // The compiler is suggesting I should inherit from EventArgs, what is it????
    { 
        public LayOffCause Cause { get; set; }
    }
}
