using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern_BilllingSystemSample2
{
    //Defining Client who will request the access to Adaptee
    public class Billing
    {
        private IEmployeeTarget _employeeTarget;
        public Billing(IEmployeeTarget employee_target)
        {
            _employeeTarget = employee_target;
        }
        public void ShowEmployees()
        {
            string employeesInfo = _employeeTarget.EmployeeList();
            Console.WriteLine("Employee:" + employeesInfo);
        }
    }
}
