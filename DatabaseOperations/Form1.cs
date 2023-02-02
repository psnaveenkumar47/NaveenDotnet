using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseOperations
{
    public partial class Form1 : Form
    {
        string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
        SqlConnection connobject;
        string strSelect = @"Select * From EmployeeTable";
        string strInsert;
        SqlCommand selectCommand;
        SqlCommand insertCommand;
        SqlDataReader dr;
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                if(connobject.State==ConnectionState.Closed)
                { 
                    connobject.Open();
                    dr=selectCommand.ExecuteReader();
                }
                if(dr.Read())
                {
                    txtID.Text = dr["ID"].ToString();
                    txtName.Text = dr[""].ToString();
                    txtSalary.Text = dr["ID"].ToString();
                    txtDept.Text = dr["ID"].ToString();
                    flag = false;
                }
            }
           
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(dr!=null&&!dr.IsClosed)
            {
                if(dr.Read())
                {
                    txtID.Text=dr["ID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtSalary.Text = dr["Salary"].ToString();
                    txtDept.Text = dr["DID"].ToString();

                }
                else
                {
                    dr.Close();
                    connobject.Close();
                    MessageBox.Show("All Records Displayed");
                }
            }
            else
            {
                MessageBox.Show("Click Select Button First");
            }
        }
    }
}
