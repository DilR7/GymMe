using FinalProject_A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_A.Factory
{
    public class UserFactory
    {
        public static MsUser Create(String username, String email, String gender, String password, DateTime DOB, String userRole)
        {
            MsUser user = new MsUser()
            {
                UserName = username,
                UserEmail = email,
                UserGender = gender,
                UserPassword = password,
                UserDOB = DOB,
                UserRole = userRole
            };
            return user;
        }
    }
}