using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Models;
using WebStore.Services.Interfaces;

namespace WebStore.Services
{
    public class WorkWithEmployee : IEmployee
    {

        private List<Employee> _Employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Александр", LastName = "Амелькин", MiddleName = "Алексеевич", Age = 33, City = "Moscow", Email = "gmaster056@gmail.com", Job = "Product Owner"},
            new Employee { Id = 2, FirstName = "Николай", LastName = "Хрипаев", MiddleName = "Владимирович", Age = 30, City = "Balashikha", Email = "nikolay@gmail.com", Job = "Product Manager"},
            new Employee { Id = 3, FirstName = "Маским", LastName = "Верчинко", MiddleName = "Александрович", Age = 29, City = "Nicosia", Email = "iosdeveloper@gmail.com", Job = "Middle Developer"},
            new Employee { Id = 4, FirstName = "Роман", LastName = "Кузнецов", MiddleName = "Юрьевич", Age = 27, City = "Murmansk", Email = "saintera@gmail.com", Job = "Senior Developer"},
            new Employee { Id = 5, FirstName = "Дмитрий", LastName = "Штойцман", MiddleName = "Анатольевич", Age = 31, City = "Rostov-on-Don", Email = "bmwclub@gmail.com", Job = "Junior Developer"},
            new Employee { Id = 6, FirstName = "Андрей", LastName = "Лебедев", MiddleName = "Владимирович", Age = 43, City = "Orenburg", Email = "builder@gmail.com", Job = "Team Lead"}
        };

        private int _CurrentMaxId;

        public WorkWithEmployee()
        {
            _CurrentMaxId = _Employees.Max(i => i.Id);
        }

        public int Create(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            employee.Id = ++_CurrentMaxId;
            _Employees.Add(employee);

            return employee.Id;
        }

        public bool Delete(int id)
        {
            var item = GetById(id);
            if (item is null) return false;
            return _Employees.Remove(item);
        }

        public List<Employee> GetAll() => _Employees;

        public Employee GetById(int id) => _Employees.Find(x => x.Id == id);

        public bool Update(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            var item = GetById(employee.Id);
            if (item is null) return false;

            item.FirstName = employee.FirstName;
            item.MiddleName = employee.MiddleName;
            item.LastName = employee.LastName;
            item.Age = employee.Age;
            item.Job = employee.Job;

            return true;

        }
    }
}
