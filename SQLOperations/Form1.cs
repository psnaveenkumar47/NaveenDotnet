using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQLOperations
{
    public partial class Form1 : Form
    {
        SqlConnection connobject;
        SqlCommand commandobject;
        IDataReader dr;
        string strcmd;
        string strconn = "Data Source=PRSQL;Initial Catalog=adonet;User ID=labuser;Password=Welcome123$";

        public Form1()
        {
            InitializeComponent();
            connobject = new SqlConnection(strconn);
            commandobject = new SqlCommand();
            commandobject.Connection = connobject;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button_insert_Click(object sender, EventArgs e)
        {
            strcmd = @"Insert Into EmployeeTable Values('" + txt_empid.Text + "','" + txt_empname.Text + "','" + txt_empsalary.Text + "','" + txt_dptid.Text + "')";
            commandobject.CommandText = strcmd;
            connobject.Open();
            int i = commandobject.ExecuteNonQuery();
            connobject.Close();
            MessageBox.Show( i+  " Records Inserted");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            strcmd = @"UPDATE EmployeeTable SET EmployeeSalary='" + txt_empsalary.Text + "' WHERE EmployeeID='" + txt_empid.Text + "' ";
            
            commandobject.CommandText = strcmd;
            connobject.Open();
            int i=commandobject.ExecuteNonQuery();
            connobject.Close();
            MessageBox.Show(i+ "Record Updated");
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            strcmd = @"Delete From EmployeeTable where EmployeeSalary>'" + txt_empsalary.Text + "'";
            commandobject.CommandText = strcmd;
            connobject.Open();
            int i = commandobject.ExecuteNonQuery();
            connobject.Close();
            MessageBox.Show(i + " Records Deleted");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.EmployeeTable' table. You can move, or remove it, as needed.
            this.employeeTableTableAdapter.Fill(this.employeeDataSet.EmployeeTable);

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
