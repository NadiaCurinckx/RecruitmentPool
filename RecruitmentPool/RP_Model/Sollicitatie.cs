using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Model
{
   public class Sollicitatie
    {
        public int IdSollicitatie { get; set; }
        public DateTime Datum { get; set; }
        public String Opmerkingen { get; set; }
        public Persoon PersoonId { get; set; }
    }
}
