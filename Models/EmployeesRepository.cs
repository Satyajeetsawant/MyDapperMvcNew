using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyDapperMvc.Models
{
    public class EmployeesRepository
    {
        private string connectionString;
        public EmployeesRepository()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
        }
        public List<Employee> GetAll()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            return db.Query<Employee>("Employee_ViewAll", commandType: CommandType.StoredProcedure).ToList();
        }
        
        public Employee Get(int Id)
        {
            using(IDbConnection db= new SqlConnection(connectionString))
            return db.Query<Employee>("Employees_Get",new { Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public Employee Create(Employee emp)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                return db.Query<Employee>("Employees_Add", emp, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }

        public Employee Update(Employee emp)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
                return db.Query<Employee>("Employees_Update", emp, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
        public Employee Delete(int Id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            return db.Query<Employee>("Employees_Delete", new { Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
        }
    }
}