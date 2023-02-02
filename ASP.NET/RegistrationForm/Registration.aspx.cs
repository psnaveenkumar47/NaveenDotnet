using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RegistrationForm
{
    public partial class Registration : System.Web.UI.Page
    {
        string str = "Data Source=PRSQL;Initial Catalog=Register;User ID=labuser;Password=Welcome123$";
        string strcmd = @"Insert into Register_Table" + "(name,Lname,Email,Gender,Address,Phone,Password) values (@name,@Lname,@Email,@Gender,@Address,@Phone,@Password)";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@lname", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Email", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@Address", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Phone", TextBox7.Text);
            cmd.Parameters.AddWithValue("@Password", TextBox10.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            Label1.Text = "Registered Successfully!";
        }
    }
    
}