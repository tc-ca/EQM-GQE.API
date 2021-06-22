using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    [Table("TY001_BUSINESS_LINE")]
    public class BusinessLine
    {
        [Column("BUSINESS_LINE_CD")]
        public int BusinessLineId { get; set; }
        
        [Column("BUSINESS_NAME_ENM")]
        public string BusinessName_EN { get; set; }

        [Column("BUSINESS_NAME_FNM")]
        public string BusinessName_FR { get; set; }

        [Column("BUSINESS_ABBR_ELBL")]
        public string Abbreviation_EN { get; set; }

        [Column("BUSINESS_ABBR_FRBL")]
        public string Abbreviation_FR { get; set; }
         
        [Column("DATE_CREATED_DTE")]  
        public DateTime CreatedOn { get; set; }

        [Column("DATE_LAST_UPDATE_DTE")]  
        public DateTime ModifiedOn { get; set; }

        [Column("DATE_DELETED_DTE")]  
        public DateTime DeletedOn { get; set; }
    }
}
