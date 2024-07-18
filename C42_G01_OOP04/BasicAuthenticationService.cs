using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP04
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Job {  get; set; }
        public bool AuthenticateUser(string userName, string password)
        {
            if (userName == UserName &&  password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AuthorizeUser(string userName, string job)
        {
            if (userName == UserName && job == Job)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
