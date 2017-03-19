using RP_Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RP.BL
{
    public  interface IPersoonLogica
    {

        Task<List<Persoon>> NeemAllePersonen();

   
        Task BewaarPersoon(Persoon persoon);

        Task WijzigPersoon(Persoon persoon, List<int> SollicitatieIds = null);

        Task VerwijderPersoon(Int32 code);


    }
}
