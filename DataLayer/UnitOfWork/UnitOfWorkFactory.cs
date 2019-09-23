using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.UnitOfWork
{
    public class UnitOfWorkFactory
    {
        public virtual IUnitOfWork Create()
        {
            return new UnitOfWork(new DbContext());
        }
    }
}
