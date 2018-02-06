using System;
using System.Web.Mvc;
using tiger_island.Context;

namespace tiger_island.Controllers
{
    public class TigerCubController : Controller
    {        
        [HttpPost]     
        public ActionResult Enter(TigerCubNameCompetition value)
        {
            try
            {
                using (var c = new TigerIslandContext())
                {                                        
                    c.TigerCubNameCompetitionEntries.Add(value);
                    c.SaveChanges();
                }

                return Json(true);
            }
            catch (Exception ex){
                return Json(ex.Message);                
            }
            
        }
    }
}
