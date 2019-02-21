using FitnessTrackAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FitnessTrackAPI.Controllers
{
    public class UsersController : ApiController
    {
        public IHttpActionResult GetUsers()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var users = context.Users.ToList();
                    return Ok(users);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}
