using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoUpdate
{
    public partial class Form1 : Form
    {
        SqlConnection ConnObject;
        SqlCommand cmdObject;
        SqlDataAdapter da;
        string strcmd;
        string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";
        SqlCommandBuilder cmdBuilder;
        DataTable dt=new DataTable();

        public Form1()
        {
            InitializeComponent();
            ConnObject=new SqlConnection(strconn);
            cmdObject=new SqlCommand();
            cmdObject.Connection= ConnObject;
            string strCmd = @"Select * From EmployeeTable";
            da=new SqlDataAdapter();
            da.SelectCommand = cmdObject;
            cmdObject.CommandText= strCmd;
            cmdObject.CommandType=CommandType.Text;
            cmdBuilder=new SqlCommandBuilder(da);
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            dt.Clear();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            da.Update(dt);
        }
    }
}
