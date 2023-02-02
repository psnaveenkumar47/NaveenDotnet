using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlConnTest
{
    internal class MainClass
    {
        static void Main()
        {
            Connected();
            Disconnect();
            Autoconnect();
        }
        static void Connected()
        {
            string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
            SqlConnection connobject = new SqlConnection(strconn);
            connobject.ConnectionString = strconn;
            SqlCommand cmdobject = new SqlCommand();
            string strcmd = @"Select * From EmployeeTable";
            cmdobject.CommandText = strcmd;
            cmdobject.Connection=connobject;
            cmdobject.CommandType=CommandType.Text;
            SqlDataReader reader;
            connobject.Open();
            reader = cmdobject.ExecuteReader();
            Console.Write("ID");
            Console.Write("\tName");
            Console.Write("\t Salary");
            Console.WriteLine("\tDepartmentID");
            Console.WriteLine("---------------------------------");
            while(reader.Read())
            {
                Console.Write(reader[0]);
                Console.Write("\t" + reader[1]);
                Console.Write("\t"+reader[2]);
                Console.WriteLine("\t" + reader[3]);
            }
            reader.Close();
            connobject.Close();
        }
        static void Disconnect()
        {
            string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
            SqlConnection connobject = new SqlConnection(strconn);
            connobject.ConnectionString = strconn;
            SqlCommand cmdobject = new SqlCommand();
            string strcmd = @"Select * From EmployeeTable";
            cmdobject.CommandText = strcmd;
            cmdobject.Connection = connobject;
            cmdobject.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmdobject;
            DataSet ds = new DataSet();

            Console.WriteLine("---------------------------------");
            adapter.Fill(ds, "MyEmployees");
            DataTable emptable = ds.Tables["MyEmployees"];
            Console.Write("ID");
            Console.Write("\t Name");
            Console.Write("\t Salary");
            Console.WriteLine("\t DepartmentID");
            Console.WriteLine("---------------------------------");
            foreach (DataRow row in emptable.Rows)
            {
                Console.Write(row[0]);
                Console.Write("\t" + row[1]);
                Console.Write(row[2]);
                Console.WriteLine("\t"+ row[3]);
            }
            Console.WriteLine("---------------------------------");
        }
        static void Autoconnect()
        {
            string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
            SqlConnection connobject = new SqlConnection(strconn);
            connobject.ConnectionString = strconn;
            SqlCommand cmdobject = new SqlCommand();
            string strcmd = @"Select * From EmployeeTable";
            cmdobject.CommandText = strcmd;
            cmdobject.Connection = connobject;
            cmdobject.CommandType = CommandType.Text;
            SqlDataReader reader;
            DataTable dt = new DataTable();
            connobject.Open();
            reader = cmdobject.ExecuteReader();            
            dt.Load(reader);
            Console.Write("ID");
            Console.Write("\t Name");
            Console.Write("\t Salary");
            Console.WriteLine("\t DepartmentID");
            Console.WriteLine("---------------------------------");
            foreach (DataRow row in dt.Rows)
            {
                Console.Write(row[0]);
                Console.Write("\t" + row[1]);
                Console.Write(row[2]);
                Console.WriteLine("\t" + row[3]);
            }
            Console.WriteLine("---------------------------------");
            reader.Close();
            connobject.Close();
        }
    }
}