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
    public class TargetController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostTarget([FromBody]Target target)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Targets.Add(target);
                    context.SaveChanges();

                    return Ok("Target was created!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [HttpGet]
        public IHttpActionResult GetTargetInfo(int userID)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                using (var context = new AppDbContext())
                {
                    var targetinfos = context.Targets.Where(p => p.UserID == userID).ToList();
                    if (targetinfos == null) return NotFound();
                    return Ok(targetinfos);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

    }
}
