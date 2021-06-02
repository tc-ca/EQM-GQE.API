using System;

namespace EQM_GQE.API.Models
{
    public class Questionnaire
    {
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string Template { get; set; }
    }
}
