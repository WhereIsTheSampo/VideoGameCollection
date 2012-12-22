using System;

namespace VGC.DataTransferObjects
{
    public class CompanyDto
    {
        // Primary Key
        public Int32 Id { get; set; }

        // Data Properties
        public String Name { get; set; }
        public String Notes { get; set; }
    }
}
