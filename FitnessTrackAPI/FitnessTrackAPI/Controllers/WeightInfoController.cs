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
    public class WeightInfoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult PostWeightInfo([FromBody]WeightInfo weightinfo)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                using (var context = new AppDbContext())
                {
                    weightinfo.CurrDate = DateTime.Now;
                    context.WeightInfos.Add(weightinfo);
                    context.SaveChanges();

                    return Ok("Weight info was created!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }



        [HttpGet]
        public IHttpActionResult GetWeightInfo(int userID)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                using (var context = new AppDbContext())
                {
                    var weightinfos = context.WeightInfos.Where(p => p.UserID == userID).ToList();
                    if (weightinfos == null) return NotFound();
                    return Ok(weightinfos);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

    }
}
