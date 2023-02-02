using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlConnection1
{
    internal class Program
    {
        static void Main()
        {
            string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            Console.WriteLine("hello");
            Console.ReadLine();
            conn.Close();
        }
    }
}
