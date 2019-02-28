using FitnessTrackAPI.Data;
using FitnessTrackAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FitnessTrackAPI.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    public class LiftInfoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostLiftInfo([FromBody]LiftInfo liftinfo)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                using (var context = new AppDbContext())
                {
                    liftinfo.CurrDate = DateTime.Now;
                    context.LiftInfos.Add(liftinfo);
                    context.SaveChanges();

                    return Ok("Lift info was created!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }
}
