using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    [Table("TY002_DOCUMENT_TYPE")]
    public class DocumentType
    {
        [Key] 
        [Column("DOCUMENT_TYPE_CD")]
        public int DocumentTypeId { get; set; }
        
        [Column("DOCUMENT_TYPE_ELBL")]
        public string DocumentType_EN { get; set; }

        [Column("DOCUMENT_TYPE_FRBL")]
        public string DocumentType_FR { get; set; }
     
        [Column("DATE_CREATED_DTE")]  
        public DateTime CreatedOn { get; set; }

        [Column("DATE_LAST_UPDATE_DTE")]  
        public DateTime ModifiedOn { get; set; }

        [Column("DATE_DELETED_DTE")]  
        public DateTime? DeletedOn { get; set; }
    }
}
