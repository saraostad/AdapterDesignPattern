using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern_BilllingSystemSample2
{
    //Defining the Adapter that implements the Target interface
    public class EmployeeAdapter : IEmployeeTarget
    {
        private Employees _employees;

        public EmployeeAdapter(Employees employees)
        {
            _employees = employees;
        }

        public string EmployeeList()
        {
            return _employees.GetEmployee();
        }
    }
}
