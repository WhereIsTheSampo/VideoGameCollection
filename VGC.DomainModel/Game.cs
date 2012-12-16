using System;
using System.Collections.Generic;

namespace VGC.DomainModel
{
    public class Game
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Data Properties
        public String Name { get; set; }
        public String ManualUrl { get; set; }
        public String Notes { get; set; }

        // Foreign Keys
        public Int32 PlatformId { get; set; }
        public Int32 LabelId { get; set; }
        public Int32 CompanyId { get; set; }

        // Navigation Properties
        public virtual Platform Platform { get; set; }
        public virtual Label Label { get; set; }
        public virtual Company Company { get; set; }
    }
}
