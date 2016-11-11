using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   public class Employye_Info
    {
        private int employeeID;
        private string EmployeeName;
        private string EmployeeAddress;
        private int employeeZipCode;
        private DateTime employeeHireDate;
        private DateTime employeeTerminationDate;
public int EmployeeID
        {
            get
            {
                return employeeID;
            }

            set
            {
                employeeID = value;
            }
        }

        public string EmployeeName1
        {
            get
            {
                return EmployeeName;
            }

            set
            {
                EmployeeName = value;
            }
        }

        public string EmployeeAddress1
        {
            get
            {
                return EmployeeAddress;
            }

            set
            {
                EmployeeAddress = value;
            }
        }

        public int EmployeeZipCode
        {
            get
            {
                return employeeZipCode;
            }

            set
            {
                employeeZipCode = value;
            }
        }

        public DateTime EmployeeHireDate
        {
            get
            {
                return employeeHireDate;
            }

            set
            {
                employeeHireDate = value;
            }
        }

        public DateTime EmployeeTerminationDate
        {
            get
            {
                return employeeTerminationDate;
            }

            set
            {
                employeeTerminationDate = value;
            }
        }
    }
}
