using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TypedUntypes
{
    public partial class Form1 : Form
    {
        SqlConnection objconnect;
        SqlCommand objcommand;
        SqlDataAdapter objadapter;
        string strcmd;
        SqlCommandBuilder cmdbuilder;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
            strcmd = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
            objconnect = new SqlConnection(strcmd);
            string strCmdSelect = @"Select * From EmployeeTable";
            objcommand = new SqlCommand(strCmdSelect, objconnect);
            objadapter = new SqlDataAdapter();
            objadapter.SelectCommand = objcommand;
            SqlCommandBuilder sqlcommandbuilder = new SqlCommandBuilder(objadapter);
            ds = new DataSet();
        }

        private void btn_typed_Click(object sender, EventArgs e)
        {
            adonetDataSet eTDS = new adonetDataSet();
            objadapter.Fill(eTDS, "EmployeeTable");
            txt_name.Text = eTDS.EmployeeTable[1].EmployeeName;
         //   eTDS.EmployeeTable[0].EmployeeId =1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["MyEmployee"];
            DataRow row= dt.Rows[2];
           row["EmployeeName"] = "wert";
            objadapter.Update(ds.Tables["MyEmployee"]);
            MessageBox.Show((string)ds.Tables["MyEmployee"].Rows[2]["EmployeeName"]);
        }

        private void btn_untyped_Click(object sender, EventArgs e)
        {
            objadapter.Fill(ds, "MyEmployee");
            txt_name.Text = (string)ds.Tables["MyEmployee"].Rows[0]["EmployeeName"];
           
            dgvEmployee.DataSource = ds;
            dgvEmployee.DataMember = "MyEmployee";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adonetDataSet.EmployeeTable' table. You can move, or remove it, as needed.
            this.employeeTableTableAdapter.Fill(this.adonetDataSet.EmployeeTable);

        }
    }
}
