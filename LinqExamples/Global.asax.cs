using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LinqExamples
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Employee e1 = new Employee { Id = 1001, Name = "Balram", Job = "President", Salary = 12000.00, Status = true };
            Employee e2 = new Employee { Id = 1002, Name = "Raju", Job = "Manager", Salary = 10000.00, Status = true };
            Employee e3 = new Employee { Id = 1003, Name = "Ajay", Job = "Salesman", Salary = 6000.00, Status = true };
            Employee e4 = new Employee { Id = 1004, Name = "James", Job = "Salesman", Salary = 6000.00, Status = true };
            Employee e5 = new Employee { Id = 1005, Name = "Jones", Job = "Clerk", Salary = 3000.00, Status = true };
            Employee e6 = new Employee { Id = 1006, Name = "Scott", Job = "Manager", Salary = 10000.00, Status = true };
            Employee e7 = new Employee { Id = 1007, Name = "Suraj", Job = "Analyst", Salary = 8000.00, Status = true };
            Employee e8 = new Employee { Id = 1008, Name = "Vijay", Job = "Analyst", Salary = 8000.00, Status = true };
            Employee e9 = new Employee { Id = 1009, Name = "Vikash", Job = "Clerk", Salary = 3000.00, Status = true };
            Employee e10 = new Employee { Id = 1010, Name = "Satish", Job = "Admin", Salary = 5000.00, Status = true };
            List<Employee> Employees = new List<Employee>() { e1, e2, e3, e4, e5, e6, e7, e8, e9, e10 };
            Application["Employees"] = Employees;
        }
    }
}