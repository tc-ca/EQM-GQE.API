using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    [Table("TY004_DOCUMENT_STATUS")]
    public class DocumentStatus
    {
        [Key] 
        [Column("DOCUMENT_STATUS_CD")]
        public int DocumentStatusId { get; set; }
        
        [Column("DOCUMENT_STATUS_ELBL")]
        public string DocumentStatus_EN { get; set; }

        [Column("DOCUMENT_STATUS_FLBL")]
        public string DocumentStatus_FR { get; set; }
         
        [Column("DATE_CREATED_DTE")]  
        public DateTime CreatedOn { get; set; }

        [Column("DATE_LAST_UPDATE_DTE")]  
        public DateTime ModifiedOn { get; set; }

        [Column("DATE_DELETED_DTE")]  
        public DateTime DeletedOn { get; set; }

    }
}
