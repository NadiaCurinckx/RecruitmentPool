using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RecruitmentPool.Models
{
    public class PersoonDetailVM
    {
        [Key]
        public int IdPersoon { get; set; }
        public String Naam { get; set; }
        public String Voornaam { get; set; }
        public String Email { get; set; }

        public MultiSelectList Sollicitaties { get; set; }
        public List<int> SollicitatieIds { get; set; }
    }
}