using WebApplication5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using WebApplication5.Controllers;

namespace WebApplication5.Models
{
    public class SignalContext: DbContext
    {
        public DbSet<SignalInDoc> Outsides { get; set; }
        public DbSet<SignalInObj> Insides { get; set; }
    }

    public class SignalDbInitializer : DropCreateDatabaseAlways<SignalContext>
    {
        protected override void Seed(SignalContext db)
        {
            db.Outsides.Add(new SignalInDoc { Id = "1", Name_signal = "a", Real_signal = "a1" });
            db.Outsides.Add(new SignalInDoc { Id = "2", Name_signal = "b", Real_signal = "b1" });
            db.Outsides.Add(new SignalInDoc { Id = "3", Name_signal = "c", Real_signal = "c1" });

            base.Seed(db);
        }
    }
}