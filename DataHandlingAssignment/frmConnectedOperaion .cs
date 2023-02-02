using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataHandlingAssignment
{
    public partial class frmConnectedOperaion : Form
    {

        SqlConnection objconnect;
        SqlCommand objcommand;
        SqlDataAdapter objadapter;
        string strcmd;
        SqlCommandBuilder cmdbuilder;
        DataSet ds;
        SqlDataReader dr;
        string strconn = "Data Source=PRSQL;Initial Catalog=MindtreeDatabase;User ID=labuser;Password=Welcome123$";

        public frmConnectedOperaion()
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
    }
}
