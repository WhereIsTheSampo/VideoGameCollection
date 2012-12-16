using System;
using System.Collections.Generic;

namespace VGC.DomainModel
{
    public class Label
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Data Properties
        public String Name { get; set; }

        // Foreign Keys
        public Int32 PlatformId { get; set; }

        // Navigation Properties
        public virtual Platform Platform { get; set; }
        public virtual IList<Game> Games { get; set; }
    }
}
