using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VGC.DomainModel;

namespace VGC.DataAccess
{
    public class DropCreateSeedDatabaseIfModelChanges 
        : DropCreateDatabaseAlways<EFDataContext>
    {
        protected override void Seed(EFDataContext context)
        {
            base.Seed(context);

            EFDataContextSeeder.LoadStaticData(context);
        }
    }
}
