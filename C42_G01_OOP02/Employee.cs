using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_OOP02
{
    #region Q03
    // We need to restrict the Gender field to be only M or F [Male or Female]
    [Flags]
    public enum Gender
    {
        Male,
        Female
    }
    #endregion
    #region Q04
    // Assign the following security privileges to the employee(guest,
    // Developer, secretary and DBA) in a form of Enum
    [Flags]
    public enum Security : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }
    #endregion
    internal class Employee : HiringDate
    {
        // Design and implement a Class for the employees in a company:
        // Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        public int Id { get; set; }
        public string Name { get; set; }
        public Security SecurityLevel { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }

        public Employee(int id, string name, int securityLevel, int salary, int d, int m, int y, Gender gender) : base(d, m, y)
        {
            Id = id;
            Name = name;
            SecurityLevel = (Security)securityLevel;
            Salary = salary;
            Gender = gender;
        }
        #region Q05
        // We want to provide the Employee Class to represent Employee data
        // in a string Form(override ToString()), display employee salary in a currency format
        #endregion
        public override string ToString()
        {
            return $"ID = {Id}, Name is {Name}, {Gender}, Security Level is {SecurityLevel}, Salary: {Salary:C}, hiring date is {Day}-{Month}-{Year}.";
        }
    }
}
