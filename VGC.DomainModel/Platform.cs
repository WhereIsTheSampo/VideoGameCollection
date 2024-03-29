﻿using System;
using System.Collections.Generic;

namespace VGC.DomainModel
{
    public class Platform
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Data Properties
        public String Name { get; set; }
        public String Notes { get; set; }

        // Foreign Keys
        public Int32 CompanyId { get; set; }

        // Navigation Properties
        public virtual Company Company { get; set; }
        public virtual IList<Game> Games { get; set; }
        public virtual IList<Label> Labels { get; set; }
    }
}
