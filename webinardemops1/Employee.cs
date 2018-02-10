using System;
using System.Collections.Generic;
using System.Text;

namespace webinardemops1
{
    class Employee
    {
        private int _empID;
        private string _empName;

        public int EmpID { get { return _empID; } }
        public string EmpName { get { return _empName; } }


        public Employee()
        {

        }
        public Employee(int empId, string EmpName)
        {
            this._empID = empId;
            this._empName = EmpName;

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("EmployeeID is " + EmpID);
            Console.WriteLine("EmployeeName is " + EmpName);
        }
    }
}