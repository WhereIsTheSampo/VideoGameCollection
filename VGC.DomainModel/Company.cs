using System;
using System.Collections.Generic;

namespace VGC.DomainModel
{
    public class Company
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Data Properties
        public String Name { get; set; }
        public String Notes { get; set; }

        // Navigation Properties
        public virtual IList<Game> Games { get; set; }
        public virtual IList<Platform> Platforms { get; set; }
    }
}
