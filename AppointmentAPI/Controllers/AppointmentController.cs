using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppointmentAPI.Controllers
{
    public class AppointmentController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Get is working");
        }
        [Route("api/Appointment/{number}")]
        public IHttpActionResult Post(int number)
        {
            return Ok($"Post is working {number}");
        }
    }
}
