using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CRUDConnectedDisconnected
{
    public partial class Departmentdetails : System.Web.UI.Page
    {
        SqlConnection objconnect;
        SqlCommand objcommand;
        DataTable dt;
        SqlDataAdapter da;
        SqlCommandBuilder cmdbuilder;
        string strconn = @"Data Source=PRSQL;Initial Catalog=MindtreeDatabase;User ID=labuser;Password=Welcome123$";
        string strcmd = @"Select * from Department";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}