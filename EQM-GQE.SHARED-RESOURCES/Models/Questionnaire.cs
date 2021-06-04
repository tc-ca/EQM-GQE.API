using System;

namespace EQM_GQE.SHARED_RESOURCES.Models
{
    public class Questionnaire
    {
        public long Id { get; set; }        

        public string Template { get; set; }

        public string DocumentTitle { get; set; }

        public BusinessLine BusinessLine { get; set; }

        public long BusinessLineId { get; set; }

        public DocumentType DocumentType { get; set; }

        public long DocumentTypeId { get; set; }

        public DocumentStatus DocumentStatus { get; set; }

        public long DocumentStatusId { get; set; }

        public SecurityClassification SecurityClassification { get; set; }

        public long SecurityClassificationId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public Boolean ActiveStatus { get; set; }

        public int DocumentVersion { get; set; }

        public DateTime EffectiveDate { get; set; }

        public string ChangeSummary { get; set; }

        public Boolean OrganisationAccessibility { get; set; }

        public long ParentId { get; set; }        

    }
}
