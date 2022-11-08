using Appointment.common.Entities;
using Appointment.common.Entities.Preset;
using Appointment.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.BL
{
    public class BusinessLayer : IBusinessLayer
    {
        public common.Entities.Appointment createAppointment(CreatingAppointmentDTO creatingAppointment)
        {
            common.Entities.Appointment appointment = new common.Entities.Appointment();
            appointment.PetID = creatingAppointment.PetID;
            appointment.DoctorID = creatingAppointment.DoctorID;
            appointment.AppointmentDate = creatingAppointment.AppoitmentDate;
            appointment.AppointmentStatus = common.Entities.Status.Confirmed;
            appointment.ObservedPetIssueID = new List<ObservedPetIssue>();
            appointment.Reason = creatingAppointment.Reason;
            appointment.Prescription = new List<PrescribedMedicine>();
            appointment.DiagnosedSymptomID = new List<DiagnosedSymptom>();
            appointment.VitalID = new Vital();
            appointment.PrescribedTestID = new List<PrescribedTest>();
            appointment.RecommendationID = new List<Recommendation>();
            return appointment;
        }

        public common.Entities.Appointment editAppointment(int appointmentID, common.Entities.Appointment editedAppointment)
        {
            throw new NotImplementedException();
        }

        public common.Entities.Appointment getAppointment(int appointmentID)
        {
            throw new NotImplementedException();
        }

        public CardDetailsDTO getCardDetailsByDoctorID(int doctorID)
        {
            throw new NotImplementedException();
        }

        public CardDetailsDTO getCardDetailsByPetID(int petID)
        {
            throw new NotImplementedException();
        }

        public CardDetailsDTO getCardDetailsForBooking(int doctorID, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Clinic> getClinic()
        {
            throw new NotImplementedException();
        }

        public List<Medicine> getMedicine()
        {
            throw new NotImplementedException();
        }

        public List<PetIssue> getPetIssue()
        {
            throw new NotImplementedException();
        }

        public List<Symptom> getSymptom()
        {
            throw new NotImplementedException();
        }

        public List<Test> getTests()
        {
            throw new NotImplementedException();
        }
    }
}
