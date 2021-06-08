using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Data.MockData;
using WebStore.Models;
using WebStore.Services.Interfaces;

namespace WebStore.Services
{
    public class WorkWithEmployee : IEmployee
    {

        private int _CurrentMaxId;

        public WorkWithEmployee()
        {
            _CurrentMaxId = MockData.Employees.Max(i => i.Id);
        }

        public int Create(Employee employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            employee.Id = ++_CurrentMaxId;
            MockData.Employees.Add(employee);

            return employee.Id;
        }

        public bool Delete(int id)
        {
            var item = GetById(id);
            if (item is null) return false;
            return MockData.Employees.Remove(item);
        }

        public List<Employee> GetAll() => MockData.Employees;

        public Employee GetById(int id) => MockData.Employees.Find(x => x.Id == id);

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
