using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwoTableWithEF.Models;


namespace TwoTableWithEF.Controllers
{
    public class EmployeeController : ApiController
    {
        static readonly IEmployeeRepository repository = new EmployeeRepository();
        public IEnumerable<Employee> GetAllEmployees()
        {
            return repository.GetAll();
        }

        public Employee GetEmployee(int id)
        {
            Employee emp = repository.Get(id);
            if (emp == null)
            {

                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return emp;
        }

        public IEnumerable<Employee> GetEmployeeByDepartment(string category)
        {
            return repository.GetAll().Where(p => string.Equals(p.EmployeeDepartment, category, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<Employee> GetEmployeeBySalary(decimal salary)
        {
            List<Employee> emplist = new List<Employee>();
            foreach(Employee emp in repository.GetAll())
            {
                if(emp.EmployeeSalary>salary)
                {
                    emplist.Add(emp) ;
                }
            }
            return emplist;
          //  return repository.GetAll().Where(p => decimal.ReferenceEquals(p.EmployeeSalary, salary, StringComparison.OrdinalIgnoreCase));
        }
        public HttpResponseMessage PostEmployee(Employee emp)
        {
            emp = repository.AddEmployee(emp);
            var response = Request.CreateResponse<Employee>(HttpStatusCode.Created, emp);
            string uri = Url.Link("DefaultApi", new { id = emp.EmployeeId });
            response.Headers.Location = new Uri(uri);
            return response;

        }
        public void PutEmployee(int id, Employee employee)
        {

            employee.EmployeeId = id;

            if (repository.Update(employee))
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
        }
        public void DeleteEmployee(int id)
        {
            Employee emp = repository.Get(id);

            if (emp == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);

            }
            repository.Remove(id);

        }
      
    }
}
