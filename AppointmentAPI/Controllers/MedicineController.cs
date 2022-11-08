using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Appointment.BL;

namespace AppointmentAPI.Controllers
{
    public class MedicineController : ApiController
    {
        IBusinessLayer bl = null;
        public MedicineController(IBusinessLayer bl)
        {
            this.bl = bl;
        }

        public IHttpActionResult Get()
        {
            return Ok("Get is working");
        }
    }
}
