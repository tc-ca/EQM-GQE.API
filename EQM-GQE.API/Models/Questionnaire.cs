using System;

namespace EQM_GQE.API.Models
{
    public class Questionnaire
    {
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }

        // Contains JSON definition for this questionnaire
        public string Template { get; set; }
    }
}
