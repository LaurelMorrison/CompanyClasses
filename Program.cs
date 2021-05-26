using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company("NSS", DateTime.Now);
            Company NotNSS = new Company("Not NSS", DateTime.Now);

            // Create three employees

            Employee Andy = new Employee();
            Andy.FirstName = "Andy";
            Andy.LastName = "Collins";
            Andy.StartDate = DateTime.Now;
            Andy.Title = "insrtuctor";

            Employee Brenda = new Employee();
            Brenda.FirstName = "Brenda";
            Brenda.LastName = "Long";
            Brenda.StartDate = DateTime.Now;
            Brenda.Title = "insrtuctor";

            Employee Christine = new Employee();
            Christine.FirstName = "Christine";
            Christine.LastName = "Doza";
            Christine.StartDate = DateTime.Now;
            Christine.Title = "TA";
            // Assign the employees to the company
            NSS.Employees.Add(Andy);
            NotNSS.Employees.Add(Brenda);
            NSS.Employees.Add(Christine);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            NSS.ListEmployee();
            NotNSS.ListEmployee();
        }
    }
}