using System;

namespace VGC.Website.Models
{
    public class GameDto
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Directly-Mapped Properties
        public String Name { get; set; }
        public String ManualUrl { get; set; }
        public String Notes { get; set; }

        // Flattened Properties
        public String PlatformName { get; set; }
        public String LabelName { get; set; }
        public String CompanyName { get; set; }
    }
}