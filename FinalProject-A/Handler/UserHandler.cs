using FinalProject_A.Model;
using FinalProject_A.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_A.Handler
{
    public class UserHandler
    {
        public static String doLogin(String username, String password)
        {
            MsUser user = UserRepository.GetUser(username,password);
            return user != null ? "Success" : "Username or Password is incorrect";
        }
    }
}