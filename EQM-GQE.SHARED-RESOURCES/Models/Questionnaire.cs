using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    [Table("CY001_QUESTIONNAIRE_TEMPLATE")]
    public class Questionnaire
    {   
        [Key]   
        [RequiredAttribute]     
        [Column("QUESTIONNAIRE_TEMPLATE_ID")]     
        public int Id { get; set; }        

        [RequiredAttribute]     
        [Column("TEMPLATE_TXT")]
        public string Template { get; set; }
        
        [RequiredAttribute]     
        [Column("DOCUMENT_TITLE_ETXT")]  
        public string DocumentTitle_EN { get; set; }
        
        [RequiredAttribute]     
        [Column("DOCUMENT_TITLE_FTXT")]  
        public string DocumentTitle_FR { get; set; }

        [RequiredAttribute]     
        [ForeignKey("BUSINESS_LINE_CD")]  
        public BusinessLine BusinessLine { get; set; }

        [RequiredAttribute]     
        [ForeignKey("DOCUMENT_TYPE_CD")]  
        public DocumentType DocumentType { get; set; }

        [RequiredAttribute]     
        [ForeignKey("DOCUMENT_STATUS_CD")]  
        public DocumentStatus DocumentStatus { get; set; }

        [RequiredAttribute]     
        [ForeignKey("SECURITY_CLASSIFICATION_CD")]  
        public SecurityClassification SecurityClassification { get; set; }

        [RequiredAttribute]     
        [Column("DATE_CREATED_DTE")]  
        public DateTime CreatedOn { get; set; }

        [Column("DATE_LAST_UPDATE_DTE")]  
        public DateTime ModifiedOn { get; set; }

        [Column("DATE_DELETED_DTE")]  
        public DateTime? DeletedOn { get; set; }
        
        [RequiredAttribute]     
        [Column("USER_CREATE_ID")]  
        public string CreatedBy { get; set; }
        
        [Column("USER_UPDATE_ID")]  
        public string ModifiedBy { get; set; }
        
        [RequiredAttribute]     
        [Column("ACTIVE_STATUS_IND")]  
        public Boolean ActiveStatus { get; set; }

        [Column("DOCUMENT_VERSION_NUM")]  
        public int DocumentVersion { get; set; }

        [Column("DATE_EFFECTIVE_BEGIN_DTE")]  
        public DateTime EffectiveFromDate { get; set; }
        
        [Column("DATE_EFFECTIVE_END_DTE")]  
        public DateTime EffectiveToDate { get; set; }

        [Column("CHANGE_SUMMARY_ETXT")]  
        public string ChangeSummary_EN { get; set; }
        
        [Column("CHANGE_SUMMARY_FTXT")]  
        public string ChangeSummary_FR { get; set; }

        [Column("ORGANIZATION_ACCESSIBILITY_IND")]  
        public Boolean OrganisationAccessibility { get; set; }
        
        [Column("PARENT_TEMPLATE_ID")]  
        public int ParentId { get; set; }        

    }
}
