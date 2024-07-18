using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04
{
    internal interface IAuthenticationService
    {
        public bool AuthenticateUser(string userName, string password);
        public bool AuthorizeUser(string userName, string job);
    }
}
