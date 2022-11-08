using Appointment.BL;
using Appointment.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppointmentAPI.Controllers
{
    public class AppointmentCardController : ApiController
    {
        IBusinessLayer businessLayer = null;
        public AppointmentCardController(IBusinessLayer businessLayer)
        {
            this.businessLayer = businessLayer;
        }

        [Route("api/AppointmentCard/docid/{doctorId}/date/{date}")]
        public  IHttpActionResult Get(int doctorId, DateTime date)
        {
            CardDetailsDTO cardDetailsDTO = this.businessLayer.getCardDetailsForBooking(doctorId, date);
            if (cardDetailsDTO == null)
                return BadRequest();
            return Ok(cardDetailsDTO);
        }

        [Route("api/AppointmentCard/petid/{petId}")]
        public IHttpActionResult Get(int petId)
        {
            CardDetailsDTO cardDetailsDTO = this.businessLayer.getCardDetailsByPetID(petId);    
            if (cardDetailsDTO == null)
                return BadRequest();
            return Ok(cardDetailsDTO);
        }
    }
}
