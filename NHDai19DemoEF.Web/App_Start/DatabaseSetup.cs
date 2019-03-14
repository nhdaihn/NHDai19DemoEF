using NHDai19DemoEF.Data.Initializer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NHDai19DemoEF.Data;

namespace NHDai19DemoEF.Web.App_Start
{
    public class DatabaseSetup
    {
        public static void Initialize()
        {
            Database.SetInitializer(new SeedData());

            using (var db = new DemoDBContext())
            {
                db.Database.Initialize(true);
            }
        }
    }
}