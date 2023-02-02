using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RDBMSoperations
{
    public partial class Form1 : Form
    {
        SqlConnection connobject;
        SqlCommand commandobject;
        IDataReader dr;
        string strcmd;
        string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
        private SqlDataReader i;
        public Form1()
        {
            InitializeComponent();
            connobject = new SqlConnection(strconn);
            commandobject = new SqlCommand();
            commandobject.Connection = connobject;
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            strcmd = "Select * From EmployeeTable";
            commandobject.CommandText = strcmd;
            connobject.Open();
            dr = commandobject.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connobject.Close();
            dgvEmployee.DataSource = dt;
        }

        private void totalsalary_btn_Click(object sender, EventArgs e)
        {
            int total=0,s;
            strcmd ="Select * From EmployeeTable ";
            commandobject.CommandText = strcmd;
            connobject.Open();
            i = commandobject.ExecuteReader();
            while(i.Read())
            {
                s = Convert.ToInt32(i["EmployeeSalary"]);
                total = total + s;
            }
            connobject.Close();
            MessageBox.Show(" Total Salary of all Employees is: "+total);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            strcmd = @"Select MIN(EmployeeSalary) From EmployeeTable ";
            commandobject.CommandText = strcmd;
            commandobject.Connection = connobject;
            connobject.Open();            
            MessageBox.Show("Minimum Salary is: "+ commandobject.ExecuteScalar().ToString());
            connobject.Close();

        }

        private void btn_maximum_Click(object sender, EventArgs e)
        {
            strcmd = @"Select MAX(EmployeeSalary) From EmployeeTable ";
            commandobject.CommandText = strcmd;
            commandobject.Connection = connobject;
            connobject.Open();
            MessageBox.Show("Maximum Salary is: "+ commandobject.ExecuteScalar().ToString());
            connobject.Close();
        }

        private void btn_average_Click(object sender, EventArgs e)
        {
            strcmd = @"Select AVG(EmployeeSalary) From EmployeeTable ";
            commandobject.CommandText = strcmd;
            commandobject.Connection = connobject;
            connobject.Open();
            MessageBox.Show( "Average Salary is: "+ commandobject.ExecuteScalar().ToString());
            connobject.Close();
        }
    }
}
