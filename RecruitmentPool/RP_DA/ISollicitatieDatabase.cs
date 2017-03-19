using RP_Model;
using System.Data.Entity;
using System.Threading.Tasks;



namespace RP_DA
{
  public  interface ISollicitatieDatabase
    {
        DbSet<Persoon> Personen { get; set; }
        DbSet<Sollicitatie> Sollicitaties { get; set; }

        Task<int> SaveChangesAsync();
    }
}
