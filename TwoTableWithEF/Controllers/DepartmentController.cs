using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TwoTableWithEF.Models;

namespace TwoTableWithEF.Controllers
{
    public class DepartmentController : ApiController
    {
        static readonly IDepartmentRepository repository = new DepartmentRepository();
        public IEnumerable<Department> GetAllDepts()
        {
            return repository.GetAll();
        }

        public Department GetDept(int id)
        {
            Department dpt = repository.Get(id);
            if (dpt == null)
            {

                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return dpt;
        }

       
        public HttpResponseMessage PostDept(Department dpt)
        {
            dpt = repository.AddDept(dpt);
            var response = Request.CreateResponse<Department>(HttpStatusCode.Created, dpt);
            string uri = Url.Link("DefaultApi", new { id = dpt.DepartmentId });
            response.Headers.Location = new Uri(uri);
            return response;

        }
        public void PutDept(int id, Department depts)
        {

            depts.DepartmentId = id;

            if (repository.Update(depts))
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
        }
        public void DeleteDept(int id)
        {
            Department dpt = repository.Get(id);

            if (dpt == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);

            }
            repository.Remove(id);

        }
    }
}
