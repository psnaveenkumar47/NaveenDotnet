using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DisplayNextsamebutton
{
    public partial class Form1 : Form
    {
        SqlConnection objconnect;
        SqlCommand objcommand;
        SqlDataAdapter objadapter;
        string strcmd;
        SqlCommandBuilder cmdbuilder;
        DataSet ds;
        SqlDataReader dr;
        bool flag = true;

        string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";



        public Form1()
        {
            InitializeComponent();
            strcmd = @"Select EmployeeID,EmployeeName,EmployeeSalary From EmployeeTable";
            objconnect = new SqlConnection();
            objconnect.ConnectionString = strconn;
            objcommand = new SqlCommand();
            objcommand.Connection = objconnect;
            objcommand.CommandType = CommandType.Text;
            objcommand.CommandText = strcmd;
            objconnect.Open();
            dr = objcommand.ExecuteReader();


        }
        private void End()
        {
            dr.Close();
            objconnect.Close();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            bool drflag = false;
            if ((((Button)sender).Name == "btn_next"))
            {
                flag = true;
            }
            if (!dr.IsClosed)
            {
                if ((flag == true) && (drflag = dr.Read()))
                {
                    txt_ID.Text = dr[0].ToString();
                    txt_name.Text = dr[1].ToString();
                    txt_salary.Text = dr[2].ToString();
                }
                if ((flag == true) && (drflag == false))
                {
                    this.End();
                }
            }
            else
            {
                MessageBox.Show("object is disposed");
            }
        }

        private void btn_populate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Load(dr);
            EmployeeGrid.DataSource = dt;
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
