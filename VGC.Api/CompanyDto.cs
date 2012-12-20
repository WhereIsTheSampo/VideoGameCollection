using System;

namespace VGC.Api
{
    public class CompanyDto
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Directly-Mapped Properties
        public String Name { get; set; }
        public String Notes { get; set; }
    }
}