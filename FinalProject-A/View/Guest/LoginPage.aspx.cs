using FinalProject_A.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_A.View.Guest
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            String username = usernametb.Text;
            String password = passwordtb.Text;

            errorlbl.Text = AuthController.doLogin(username, password);
        }
    }
}