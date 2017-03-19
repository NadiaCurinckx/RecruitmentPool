using RecruitmentPool.Models;
using RP.BL;
using RP_DA;
using RP_Model;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace RecruitmentPool.Controllers
{
    public class PersoonController : Controller
    {
        private readonly SollicitatieDatabase _sollicitatieDatabase = new SollicitatieDatabase();

        //private readonly SollicitatieLogica _sollicitatieLogica;
        private readonly PersoonLogica _persoonLogica;


        public PersoonController()
        {
            _persoonLogica = new PersoonLogica(_sollicitatieDatabase);
        }



        public async Task<ActionResult> Index()
        {
            var personen = await _persoonLogica.NeemAllePersonen();

            return View(new PersoonLijstVM { Personen = personen });
        }


    }
}