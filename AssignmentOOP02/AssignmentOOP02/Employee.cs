using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP02
{
    #region Solution Q4
    //4.Assign the following security privileges to the employee (guest, Developer, secretary and DBA)
    //in a form of Enum
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    #endregion

    #region Solution Q1
    //1.Design and implement a Class for the employees in a company:
    //⮚	Employee is identified by an ID, Name, security level, salary, hire date and Gender.

    internal class Employee
    {
        private int id;
        private string name;
        private SecurityLevel securityLevel;  
        private decimal salary;
        private HiringDate hireDate; 
        private string gender;

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, string gender)
        {
            this.Id = id;
            this.Name = name;
            this.SecurityLevel = securityLevel;
            this.Salary = salary;
            this.HireDate = hireDate;
            this.Gender = gender;
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("ID must be a positive integer.");
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative.");
                salary = value;
            }
        }

        public HiringDate HireDate
        {
            get { return hireDate; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Hire Date cannot be null.");
                hireDate = value;
            }
        }

        public string Gender
        {
            get { return gender; }

            #region Solution Q3
            //3.We need to restrict the Gender field to be only M or F [Male or Female] 
            set
            {
                if (value != "M" && value != "F")
                    throw new ArgumentException("Gender must be 'M' (Male) or 'F' (Female).");
                gender = value;
            }
            #endregion
        }

        #region Solution Q5

        //5.We want to provide the Employee Class to represent Employee data in a string Form
        //(override ToString ()), display employee salary in a currency format.
        //[ use String.Format Function]
        public override string ToString()
        {
            string salaryFormatted = String.Format("{0:C}", Salary);

            return $"Employee ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Security Level: {SecurityLevel}\n" +
                   $"Salary: {salaryFormatted}\n" +
                   $"Hire Date: {HireDate.GetFormattedDate()}\n" +
                   $"Gender: {(Gender == "M" ? "Male" : "Female")}";
        }
        #endregion
    }
    #endregion
}
