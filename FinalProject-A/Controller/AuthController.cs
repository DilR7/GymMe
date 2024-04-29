using FinalProject_A.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace FinalProject_A.Controller
{
    public class AuthController
    {
        public static String checkUsername(String username)
        {
            String response = "";
            if (username.Equals("")) response = "Username cannot be empty";
            else if (username.Length < 5 || username.Length > 15) response = "Username must be between 5 and 15 alphabet";
            return response;
        }
        public static String checkEmail(String email)
        {
            String response = "";
            if (email.Equals("")) response = "Email cannot be empty";
            else if (!email.EndsWith(".com")) response = "Email must ends with .com";
            return response;
        }

        public static string checkGender(String gender)
        {
            String response = "";
            if (String.IsNullOrEmpty(gender)) response = "Choose a gender";
            return response;

        }

        public static String checkPassword(String password)
        {
            String response = "";
            if (password.Equals("")) response = "Password cannot be empty";
            else
            {
                foreach (char c in password)
                {
                    if (!char.IsDigit(c))
                    {
                        response = "Password must alphanumeric";
                    }
                }
            }
            return response;
        }

        public static String checkCpassword(String Cpassword, String password)
        {
            String response = "";
            if (Cpassword.Equals("")) response = "Confirmation Password cannot be empty";
            else if (!Cpassword.Equals(password)) response = "Confirmation Password must be the same with password";
            return response;
        }

        public static String checkDOB(DateTime DOB)
        {
            String response = "";
            if (DOB.Equals("")) response = "Date of Birth cannot be empty";
            return response;
        }

        public static String doRegister(String username, String email, String gender, String password, String Cpassword, DateTime DOB)
        {
            String response = checkUsername(username);
            if (response.Equals("")) response = checkEmail(email);
            if (response.Equals("")) response = checkGender(gender);
            if (response.Equals("")) response = checkPassword(password);
            if (response.Equals("")) response = checkCpassword(Cpassword, password);
            if (response.Equals("")) response = checkDOB(DOB);
            return response;
        }

        public static String doLogin(String username, String password)
        {
            String response = checkUsername(username);
            if (response.Equals("")) response = checkPassword(password);
            if (response.Equals("")) response = UserHandler.doLogin(username, password);
            return response;
        }
    }
}