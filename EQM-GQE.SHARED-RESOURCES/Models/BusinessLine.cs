using System;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    public class BusinessLine
    {
        public long Id { get; set; }
        
        public string BusinessName_EN { get; set; }

        public string BusinessName_FR { get; set; }

        public string Abbreviation_EN { get; set; }

        public string Abbreviation_FR { get; set; }
    }
}
