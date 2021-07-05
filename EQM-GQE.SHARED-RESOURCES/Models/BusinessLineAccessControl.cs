using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    [Table("CY002_BUSINESS_LINE_ACCESS_CONTROL")]
    public class BusinessLineAccessControl
    {
        [Key]
        [Required]
        [Column("ACCESS_CONTROL_ID")]
        public int Id { get; set; }

        [Required]
        [ForeignKey("BUSINESS_LINE_CD")]
        public BusinessLine BusinessLineId { get; set; }

        [Required]
        [Column("USER_ID")]
        public string UserId { get; set; }

        [Required]
        [Column("ACCESS_CONTROL_ACTIVE_IND")]
        public bool Active { get; set; }

        [Required]
        [Column("DATE_CREATED_DTE")]
        public DateTime CreatedOn { get; set; }

        [Column("DATE_LAST_UPDATE_DTE")]
        public DateTime ModifiedOn { get; set; }

        [Column("DATE_DELETED_DTE")]
        public DateTime? DeletedOn { get; set; }

    }
}
