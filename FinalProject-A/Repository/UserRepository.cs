using FinalProject_A.Factory;
using FinalProject_A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_A.Repository
{
    public class UserRepository
    {
        private static GymMeEntities db = DatabaseSingleton.GetInstance();
        public static MsUser GetUser(String username, String password)
        {
            return (from x in db.MsUsers where x.UserName.Equals(username) && x.UserPassword.Equals(password) select x).FirstOrDefault();
        }

        public void AddUser(String username, String email, String gender, String password, DateTime DOB, String userRole)
        {
            MsUser user = UserFactory.Create(username, email, gender, password, DOB, userRole);
            db.MsUsers.Add(user);
            db.SaveChanges();
        }
    }
}