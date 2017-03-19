using RP_DA;
using RP_Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace RP.BL
{
    public class PersoonLogica : IPersoonLogica
    {
        private readonly ISollicitatieDatabase _database;

        public PersoonLogica(ISollicitatieDatabase database)
        {
            _database = database;
        }

        public Task BewaarPersoon(Persoon persoon)
        {
            throw new NotImplementedException();
        }

        public Task<List<Persoon>> NeemAllePersonen()
        {
            return _database.Personen.ToListAsync();
        }

        public Task VerwijderPersoon(int code)
        {
            throw new NotImplementedException();
        }

        public Task WijzigPersoon(Persoon persoon, List<int> SollicitatieIds = null)
        {
            throw new NotImplementedException();
        }

        Task<List<Persoon>> IPersoonLogica.NeemAllePersonen()
        {
            throw new NotImplementedException();
        }
    }
}
