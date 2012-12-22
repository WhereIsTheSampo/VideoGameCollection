using System;

namespace VGC.DataTransferObjects
{
    public class PlatformDto
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Data Properties
        public String Name { get; set; }
        public String Notes { get; set; }

        // Foreign Keys
        public Int32 CompanyId { get; set; }

        // Flattened Properties
        public String CompanyName { get; set; }
    }
}
