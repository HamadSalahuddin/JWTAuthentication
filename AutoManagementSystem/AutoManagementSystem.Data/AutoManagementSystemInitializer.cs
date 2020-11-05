using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Data
{
    public class AutoManagementSystemInitializer: DropCreateDatabaseIfModelChanges<AutoManagementSystemEntities>
    {
    }
}
