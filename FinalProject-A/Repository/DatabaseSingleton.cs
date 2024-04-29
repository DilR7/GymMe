using FinalProject_A.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_A.Repository
{
    public class DatabaseSingleton
    {
        private static GymMeEntities db = null;
        public DatabaseSingleton() { }
        public static GymMeEntities GetInstance()
        {
            if (db == null)
            {
                db = new GymMeEntities();
            }
            return db;
        }
    }
}