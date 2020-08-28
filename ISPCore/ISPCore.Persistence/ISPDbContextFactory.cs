using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPCore.Persistence
{
    public class ISPDbContextFactory : DesignTimeDbContextFactoryBase<DBContext>
    {
        protected override ISPCore.Persistence.DBContext CreateNewInstance(DbContextOptions<DBContext> options)
        {
            return new DBContext(options);
        }
    }
}
