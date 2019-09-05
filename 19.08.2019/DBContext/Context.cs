using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _19._08._2019.DBContext
{
    public class Context<T>: System.Data.Entity.DbContext
    {
        public Context() : base("Model1")
    { }
        public DbSet<T> table { get; set; }
    }
}