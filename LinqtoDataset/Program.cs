using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LinqtoDataset
{
    internal class Program
    {
        public Program()
        {

        }
        static void Main()
        {

           // UntypedDataSet();
            TypedDataSet();
            TwoTableQuery();
        }
        static void UntypedDataSet()
        {
            SqlConnection connobject = new SqlConnection();
            SqlCommand cmdobject = new SqlCommand();
            string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
            string strcmd = "Select EmployeeID,EmployeeName,EmployeeSalary,DepartmentID From EmployeeTable";
            connobject.ConnectionString = strconn;
            cmdobject.Connection = connobject;
            cmdobject.CommandType = CommandType.Text;
            cmdobject.CommandText = strcmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmdobject;
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "MyEmployees");
            DataTable emptable = ds.Tables["MyEmployees"];
            var query = from emp in emptable.AsEnumerable()
                        select new
                        {
                            ID = emp.Field<Byte>("EmployeeID"),
                            Name = emp.Field<String>("EmployeeName"),
                            Salary = emp.Field<decimal>("EmployeeSalary"),
                            DID = emp.Field<int>("DepartmentID")
                        };
            Console.Write("ID\t");
            Console.Write("Name\t");
            Console.Write("\tSalary\t");
            Console.Write("\tDID\t");
            Console.WriteLine("--------------------------------");
            foreach(var e in query)
            {
                Console.Write("{0}\t",e.ID);
                Console.Write("{0}\t", e.Name);
                Console.Write("{0}\t", e.Salary);
                Console.Write("{0}\t", e.DID);
            }

        }
        static void TypedDataSet()
        {
            DataSet1 eds = new DataSet1();
            DataSet1TableAdapters.EmployeeTableTableAdapter emplyoeeTableAdapter = new DataSet1TableAdapters.EmployeeTableTableAdapter();
            
            emplyoeeTableAdapter.Fill(eds.EmployeeTable);



            var query = from emp in eds.EmployeeTable
                        select new
                        {
                            ID = emp.EmployeeId,
                            Name = emp.EmployeeName,
                            Salary = emp.EmployeeSalary,
                            Department = emp.DepartmentID
                        };
            // EmplyoeeDataSet.EmplyoeeRow row = eds.Emplyoee.NewEmplyoeeRow();
            //row.Name = "Bhima";
            //row.Salary = 18339;
            //row.DId = 1;
            //eds.Emplyoee.Rows.Add(row);
            //emplyoeeTableAdapter.Update(eds.Emplyoee);



            Console.WriteLine("ID\t");
            Console.WriteLine("Name\t");
            Console.WriteLine("\tSalary\t");
            Console.WriteLine("\tDepartment");
            Console.WriteLine("_____________________________________________________");
            foreach (var e in query)
            {
                Console.WriteLine("{0}\t", e.ID);
                Console.WriteLine("{0}\t", e.Name);
                Console.WriteLine("{0}\t", e.Salary);
                Console.WriteLine("{0}\t", e.Department);
            }
        }
        static void TwoTableQuery()
        {
            SqlConnection connobject = new SqlConnection();
            SqlCommand cmdobject = new SqlCommand();
            string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
            string strcmd = "Select EmployeeID,EmployeeName,EmployeeSalary,DepartmentID From EmployeeTable";
            connobject.ConnectionString = strconn;
            cmdobject.Connection = connobject;
            cmdobject.CommandType = CommandType.Text;
            cmdobject.CommandText = strcmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adapter.SelectCommand = cmdobject;
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "MyEmployees");
            DataTable emptable = ds.Tables["MyEmployees"];
            strcmd = "Select DepartmentID,DepartmentName From DepartmentTable ";
            cmdobject.CommandText=strcmd;
            adapter.Fill(ds, "Department");
            DataTable Departmenttable = ds.Tables["Department"];
            var query = from emp in emptable.AsEnumerable()
                        join Department in Departmenttable.AsEnumerable()
                        on emp.Field<Byte>("DepartmentID") equals Department.Field<int>("DepartmentID")
                        select new
                        {
                            ID = emp.Field<Byte>("EmployeeID"),
                            Name = emp.Field<String>("EmployeeName"),
                            Salary = emp.Field<decimal>("EmployeeSalary"),
                            DID = emp.Field<int>("DepartmentID")
                        };
            Console.Write("ID\t");
            Console.Write("Name\t");
            Console.Write("\tSalary\t");
            Console.Write("\tDID\t");
            Console.WriteLine("--------------------------------");
            foreach (var e in query)
            {
                Console.Write("{0}\t", e.ID);
                Console.Write("{0}\t", e.Name);
                Console.Write("{0}\t", e.Salary);
                Console.Write("{0}\t", e.DID);
            }

        
    }
    }
}
