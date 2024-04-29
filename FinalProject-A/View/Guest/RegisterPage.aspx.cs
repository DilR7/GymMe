using FinalProject_A.Controller;
using FinalProject_A.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject_A.View.Guest
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registerbtn_Click(object sender, EventArgs e)
        {
            String username = usernametb.Text;
            String email = emailtb.Text;
            String gender = genderlbl.Text;
            String password = passwordtb.Text;
            String cpassword = cpasswordtb.Text;
            DateTime DOB = DateTime.Parse(dobtb.Text);

            errorlbl.Text = AuthController.doRegister(username, email, gender, password, cpassword, DOB);
            UserRepository userRepository = new UserRepository();
            userRepository.AddUser(username, email, "male", password, DOB, "Customer");
            Response.Redirect("~/View/Customer/CustomerNavBar.aspx");
        }
    }
}