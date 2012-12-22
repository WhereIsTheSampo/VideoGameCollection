using System;

namespace VGC.Api
{
    public class LabelDto
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Data Properties
        public String Name { get; set; }

        // Foreign Keys
        public Int32 PlatformId { get; set; }

        // Flattened Properties
        public String PlatformName { get; set; }
    }
}
