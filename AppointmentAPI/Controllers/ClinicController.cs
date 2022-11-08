using Appointment.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppointmentAPI.Controllers
{
    public class ClinicController : ApiController
    {
        IBusinessLayer bl = null;
        public ClinicController(IBusinessLayer bl)
        {
            this.bl = bl;
        }

        public IHttpActionResult Get()
        {
            return Ok("Get is working");
        }
    }
}
