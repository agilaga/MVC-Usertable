using MVC_user_table.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_user_table.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> emp;
        public HomeController()
        {
            emp = new List<Employee>()
        {
            new Employee()
            { EmployeeId =1,FirstName="Agil",LastName="Aghazada", Email="agil@gmail.com", Salary=999999, Company="AGHALAR", Dept="HOLDER/" },
            new Employee()
            { EmployeeId =2,FirstName="Akhmed",LastName="Sadigov", Email="ahmed@gmail.com", Salary=5000, Company="AGHALAR", Dept="IT" },
            new Employee()
            { EmployeeId =3,FirstName="Mahammad",LastName="Mammadov", Email="magapink@gmail.com", Salary=4999, Company="AGHALAR", Dept="Pinkchiler" },
            new Employee()
            { EmployeeId =4,FirstName="Ali",LastName="Aliyev", Email="ali@gmail.com", Salary=4000, Company="AGHALAR", Dept="IR of IRAN" },
            new Employee()
            { EmployeeId =5,FirstName="Əssslan",LastName="Kazimov", Email="asslan@gmail.com", Salary=6000, Company="AGHALAR", Dept="BACKEND" },
            new Employee()
            { EmployeeId =6,FirstName="Bolonizm",LastName="Aliyev", Email="efgan@gmail.com", Salary=3169, Company="AGHALAR", Dept="7 dekabr 2023" },

        };
        }
        public ActionResult Index()
        {

            return View(emp);
        }
    }
}