using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Data.Infrastructure
{
    public class DbFactory: Disposable, IDbFactory
    {
        AutoManagementSystemEntities dbContext;

        public AutoManagementSystemEntities Init()
        {
            return dbContext ?? (dbContext = new AutoManagementSystemEntities());
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
