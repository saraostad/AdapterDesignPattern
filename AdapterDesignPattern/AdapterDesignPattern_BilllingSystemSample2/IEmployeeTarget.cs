using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern_BilllingSystemSample2
{
    //Declaring the Target that the Client will use
    public interface IEmployeeTarget
    {
        string EmployeeList();
    }
}
