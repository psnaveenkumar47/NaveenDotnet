using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace CRUDConnectedDisconnected
{
    public partial class operations : System.Web.UI.Page
    {
        SqlConnection objconnect;
        SqlCommand objcommand;
        DataTable dt;
        DataTable dt2;
        SqlDataAdapter da;
        SqlCommandBuilder cmdbuilder;
        string strconn = @"Data Source=PRSQL;Initial Catalog=MindtreeDatabase;User ID=labuser;Password=Welcome123$";
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcmd = @"Select * from Department";
            objconnect = new SqlConnection(strconn);
            objcommand = new SqlCommand(strcmd, objconnect);
            da = new SqlDataAdapter();
            da.SelectCommand=objcommand;
            cmdbuilder = new SqlCommandBuilder(da);
             dt = new DataTable();
            da.Fill(dt);    
            gvEmployee.DataSource = dt;
            gvEmployee.DataBind();
        }
        protected void gvSearch_RowDataBound(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Select")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                string strcmd = @"SELECT EmpId, EmpName,Salary FROM Employees WHERE DeptId = " +(rowIndex+1) + "";
                objconnect = new SqlConnection(strconn);
                objcommand = new SqlCommand(strcmd, objconnect);
                da = new SqlDataAdapter();
                da.SelectCommand = objcommand;
                cmdbuilder = new SqlCommandBuilder(da);
                dt2 = new DataTable();
                da.Fill(dt2);
                gvDetails.DataSource = dt2;
                gvDetails.DataBind();
            }
        }
        protected void gvdetail_RowDataBound(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Aggregate")
            {
                 string strcmd = @"SELECT MAX(EmployeeSalary) From Employees";
                objconnect = new SqlConnection(strconn);
                objcommand = new SqlCommand(strcmd, objconnect);
                da = new SqlDataAdapter();
                da.SelectCommand = objcommand;
                cmdbuilder = new SqlCommandBuilder(da);
               // Console.WriteLine(objcommand.ExecuteScalar().ToString());
                
            }
            }

        protected void gvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}