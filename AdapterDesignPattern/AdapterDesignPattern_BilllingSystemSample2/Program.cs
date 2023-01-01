using System;

namespace AdapterDesignPattern_BilllingSystemSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing the Target's object via Adapter
            IEmployeeTarget target = new EmployeeAdapter(new Employees());
            Billing billing = new Billing(target);
            billing.ShowEmployees();
            Console.ReadKey();
        }
    }
}
