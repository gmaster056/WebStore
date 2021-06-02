using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.Services.Interfaces;
using WebStore.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.Controllers
{
    [Route("employees")]
    public class EmployeesController : Controller
    {

        private readonly IEmployee _Employees;

        public EmployeesController(IEmployee employee) => _Employees = employee;

        [Route("")]
        public IActionResult Index() => View(_Employees.GetAll());

        [Route("edit")]
        public IActionResult Edit(int? Id)
        {
            if (Id is null)
                return View(new EmployeeViewModel());

            var employee = _Employees.GetById((int)Id);

            if (employee is null) return NotFound();

            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<Employee, EmployeeViewModel>()
                );

            var mapper = new Mapper(config);

            var model = mapper.Map<EmployeeViewModel>(employee);

            return View(model);
        }

        //[Route("edit")]
        //public IActionResult Edit(EmployeeViewModel model)
        //{

        //}

        [Route("save")]
        [HttpPost]
        public IActionResult Save(EmployeeViewModel employee)
        {
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<EmployeeViewModel, Employee>()
                );

            var mapper = new Mapper(config);

            var Model = mapper.Map<Employee>(employee);

            if (Model.Id == 0)
                _Employees.Create(Model);
            else
                _Employees.Update(Model);

            return RedirectToAction("Index");
        }

        [Route("delete")]
        [HttpPost]
        public IActionResult Delete(int Id)
        {
            if (Id <= 0) return BadRequest();

            _Employees.Delete(Id);

            return RedirectToAction("Index");
        }
    }
}
