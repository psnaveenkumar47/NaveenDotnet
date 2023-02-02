using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoTableWithEF.Models
{
   interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();

        Department AddDept(Department dep);
        void Remove(int id);
        bool Update(Department dep);
        Department Get(int id);
    }
}