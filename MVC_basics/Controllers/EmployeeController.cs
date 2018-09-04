using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_basics.Models;

namespace MVC_basics.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //public ActionResult Details()
        //{
        //    Employee employee = new Employee()
        //    {
        //        EmployeeId = 101,
        //        Name = "John",
        //        Gender = "Male",
        //        City = "New York"
        //    };

        //    return View(employee);
        //}

        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Employee> employees = employeeContext.Employees.ToList();

            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }
    }
}