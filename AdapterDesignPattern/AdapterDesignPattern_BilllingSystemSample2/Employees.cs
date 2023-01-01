using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern_BilllingSystemSample2
{
    //Defining the Adaptee to be accessed by the Client
    public class Employees
    {
        public string GetEmployee()
        {
            return "John Francis, Manager";
        }

    }
}
