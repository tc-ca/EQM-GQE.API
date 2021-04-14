using System;

namespace EQM_GQE.API
{
    public class Questionnaire
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string Template { get; set; }
    }
}
