using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Models;
namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly IConfiguration _config;
        public EmployeeRepository(IConfiguration config)
        {

            this._config = config;

        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnectionString"));
            }
        }


        public async Task<Employee> GetByID(int id)
        {
            using (IDbConnection conn = Connection)
            {
                string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee WHERE ID = @ID";
                conn.Open();
                var result = await conn.QueryAsync<Employee>(sQuery, new { ID = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<List<Employee>> GetByDateOfBirth(DateTime dateOfBirth)
        {
            using (IDbConnection conn = Connection)
            {
                string sQuery = "SELECT ID, FirstName, LastName, DateOfBirth FROM Employee WHERE DateOfBirth = @DateOfBirth";
                conn.Open();
                var result = await conn.QueryAsync<Employee>(sQuery, new { DateOfBirth = dateOfBirth });
                return result.ToList();
            }
        }

        public int AddEmployee(Employee Emp)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                IDbTransaction sqltrans = conn.BeginTransaction();
                var param = new DynamicParameters();
                param.Add("@Fname", Emp.FirstName);
                param.Add("@Lname", Emp.LastName);
                param.Add("@Dob", Emp.DateOfBirth);
                var result = conn.Execute("AddEmployee", param, sqltrans, 0, System.Data.CommandType.StoredProcedure);
                if (result > 0)
                {
                    sqltrans.Commit();
                }
                else
                {
                    sqltrans.Rollback();
                }
                return result;
            }
        }
    }

}