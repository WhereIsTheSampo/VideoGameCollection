using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VGC.DomainModel;

namespace VGC.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base()
        {

        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Label> Labels { get; set; }
    }
}
