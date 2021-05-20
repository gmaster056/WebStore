using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> _Employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Александр", LastName = "Амелькин", MiddleName = "Алексеевич", Age = 33, Job = "Product Owner"},
            new Employee { Id = 2, FirstName = "Николай", LastName = "Хрипаев", MiddleName = "Владимирович", Age = 30, Job = "Product Manager"},
            new Employee { Id = 3, FirstName = "Анатолий", LastName = "Верчинко", MiddleName = "Александрович", Age = 29, Job = "Middle Developer"},
            new Employee { Id = 4, FirstName = "Роман", LastName = "Кузнецов", MiddleName = "Юрьевич", Age = 27, Job = "Senior Developer"},
            new Employee { Id = 5, FirstName = "Дмитрий", LastName = "Штойцман", MiddleName = "Анатольевич", Age = 31, Job = "Junior Developer"},
            new Employee { Id = 6, FirstName = "Андрей", LastName = "Лебедев", MiddleName = "Владимирович", Age = 43, Job = "Team Lead"}
        };

        public IActionResult Index()
        {
            return View();
        }

        [Route("/cards")]
        public IActionResult Cards()
        {
            return View(_Employees);
        }

        [Route("/card/{id}")]
        public IActionResult Card(int Id)
        {
            //Employee employee = _Employees.Find(x => x.Id == Id);
            //Employee employee = new Employee() { FirstName = "Александр", LastName = "Амелькин", MiddleName = "Алексеевич", Age = 33 };
            return View(_Employees.Find(x => x.Id == Id));
        }
    }
}
