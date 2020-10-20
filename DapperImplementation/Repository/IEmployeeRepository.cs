using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using System;
namespace Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByID(int id);
        Task<List<Employee>> GetByDateOfBirth(DateTime dateOfBirth);
        int AddEmployee(Employee Emp);
    }
}