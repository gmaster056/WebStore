using System;
using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Services.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetAll();

        Employee GetById(int id);

        int Create(Employee employee);

        bool Update(Employee employee);

        bool Delete(int id);
    }
}
