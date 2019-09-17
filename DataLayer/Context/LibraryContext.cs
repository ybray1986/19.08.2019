using _19._08._2019;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class LibraryContext: DbContext
    {
        public LibraryContext():base()
        {
        }
        public LibraryContext(string connectionString)
            : base(connectionString)
        {
        }
    }
}
