using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWeb
{
    public partial class Hellopage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("page loaded");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button clicked");
        }
        protected virtual void Page_PreInit(EventArgs e)
        {
            Response.Write("page preinit");
        }   
        protected virtual void Page_Init(EventArgs e)
        {
            Response.Write("page init");
        }
        protected virtual void Page_InitComplete(EventArgs e)
        {
            Response.Write("page inticomplete");
        }
    }
}