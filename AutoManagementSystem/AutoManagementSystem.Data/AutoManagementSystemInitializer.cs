using AutoManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoManagementSystem.Data
{
    public class AutoManagementSystemInitializer : DropCreateDatabaseIfModelChanges<AutoManagementSystemEntities>
    {
        protected override void Seed(AutoManagementSystemEntities context)
        {
            context.Brandings.Add(GetTestBranding());
            context.Commit();
        }

        public static Branding GetTestBranding()
            => new Branding
            {
                Email = "TestBranding@Test.com",
                Name = "Test Brand",
                Contact = "xxx-xxxxxxx",
                WebUrl="http://testbranding.com"
            };
    }
}
