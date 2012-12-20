using System;
using System.Data.Entity;

using VGC.DomainModel;

namespace VGC.DataAccess
{
    public class DropCreateSeedDatabaseIfModelChanges 
        : DropCreateDatabaseIfModelChanges<EFDataContext>
    {
        protected override void Seed(EFDataContext context)
        {
            base.Seed(context);

            EFDataContextSeeder.LoadStaticData(context);
        }
    }
}
