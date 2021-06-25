using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    [Table("TY003_SECURITY_CLASSIFICATION")]
    public class SecurityClassification
    {
        [Key] 
        [Column("SECURITY_CLASSIFICATION_CD")]
        public int SecurityClassificationId { get; set; }
        
        [Column("CLASSIFICATION_ELBL")]
        public string SecurityClassification_EN { get; set; }
        
        [Column("CLASSIFICATION_FRBL")]
        public string SecurityClassification_FR { get; set; }
         
        [Column("DATE_CREATED_DTE")]  
        public DateTime CreatedOn { get; set; }

        [Column("DATE_LAST_UPDATE_DTE")]  
        public DateTime ModifiedOn { get; set; }

        [Column("DATE_DELETED_DTE")]  
        public DateTime? DeletedOn { get; set; }
    }
}
