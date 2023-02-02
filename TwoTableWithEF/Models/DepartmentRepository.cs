using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwoTableWithEF.DataAccessLayer;

namespace TwoTableWithEF.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        EmployeeDataLayer DepartmentDal;
        private int _nextId = 4;
        public DepartmentRepository()
        {
            DepartmentDal = new EmployeeDataLayer();
        }
        public IEnumerable<Department> GetAll()
        {
            return DepartmentDal.Depts.ToList();
        }
        public Department Get(int id)
        {
            return DepartmentDal.Depts.ToList().Find(x => x.DepartmentId == id);
        }
        public Department AddDept(Department dept)
        {
            if (dept == null)
            {
                throw new ArgumentNullException("Department");
            }
            dept.DepartmentId = _nextId++;
            DepartmentDal.Depts.Add(dept);
            DepartmentDal.SaveChanges();
            return dept;
        }
        public bool Update(Department dep)
        {
            if (dep == null)
            {
                throw new ArgumentNullException("Department");
            }
            Department found = DepartmentDal.Depts.Find(dep.DepartmentId);
            if (found == null)
            {
                return false;
            }
            found.DepartmentId = dep.DepartmentId;
            found.DepartmentName = dep.DepartmentName;
            DepartmentDal.SaveChanges();
            return true;

        }
        public void Remove(int id)
        {
            Department found = DepartmentDal.Depts.Find(id);
            if (found != null)
            {
                throw new ArgumentNullException("Department");
            }
            DepartmentDal.Depts.Remove(found);
            DepartmentDal.SaveChanges();
        }

    }
}