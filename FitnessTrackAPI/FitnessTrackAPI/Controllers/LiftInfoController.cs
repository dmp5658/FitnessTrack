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

    }
}
