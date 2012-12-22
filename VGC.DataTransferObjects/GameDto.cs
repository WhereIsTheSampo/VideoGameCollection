using System;

namespace VGC.DomainModel.DataTransferObjects
{
    public class GameDto
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String ManualUrl { get; set; }
        public String Notes { get; set; }
        public String PlatformName { get; set; }
        public String CompanyName { get; set; }
        public String LabelName { get; set; }
    }
}
