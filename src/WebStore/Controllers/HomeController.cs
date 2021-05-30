using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static List<Employee> _Employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Александр", LastName = "Амелькин", MiddleName = "Алексеевич", Age = 33, City = "Moscow", Email = "gmaster056@gmail.com", Job = "Product Owner"},
            new Employee { Id = 2, FirstName = "Николай", LastName = "Хрипаев", MiddleName = "Владимирович", Age = 30, City = "Balashikha", Email = "nikolay@gmail.com", Job = "Product Manager"},
            new Employee { Id = 3, FirstName = "Маским", LastName = "Верчинко", MiddleName = "Александрович", Age = 29, City = "Nicosia", Email = "iosdeveloper@gmail.com", Job = "Middle Developer"},
            new Employee { Id = 4, FirstName = "Роман", LastName = "Кузнецов", MiddleName = "Юрьевич", Age = 27, City = "Murmansk", Email = "saintera@gmail.com", Job = "Senior Developer"},
            new Employee { Id = 5, FirstName = "Дмитрий", LastName = "Штойцман", MiddleName = "Анатольевич", Age = 31, City = "Rostov-on-Don", Email = "bmwclub@gmail.com", Job = "Junior Developer"},
            new Employee { Id = 6, FirstName = "Андрей", LastName = "Лебедев", MiddleName = "Владимирович", Age = 43, City = "Orenburg", Email = "builder@gmail.com", Job = "Team Lead"}
        };

        public IActionResult Index()
        {
            return View();
        }

        [Route("/employees")]
        public IActionResult Employees()
        {
            return View(_Employees);
        }

        [Route("edituser")]
        public IActionResult EditUser(int Id)
        {
            Employee employee = _Employees.Find(x => x.Id == Id);

            if (employee == null) return NotFound();

            return View(employee);
        }

        public IActionResult SaveUser(Employee employee)
        {
            _Employees.FindAll(x => x.Id == employee.Id).ForEach(s =>
            {
                s.FirstName = employee.FirstName;
                s.MiddleName = employee.MiddleName;
                s.LastName = employee.LastName;
                s.Age = employee.Age;
                s.Job = employee.Job;
            });
            
            return View("Employees",_Employees);
        }

    }
}
