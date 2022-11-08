using Appointment.Common.DTO;
using Appointment.common.Entities.Preset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.DAL
{
    public interface IAppointmentRepo
    {
        CardDetailsDTO getCardDetailsByDoctorID(int doctorID);
        CardDetailsDTO getCardDetailsByPetID(int petID);
        CardDetailsDTO getCardDetailsForBooking(int doctorID, DateTime date);
        List<Test> getTests();
        List<Clinic> getClinic();
        List<Symptom> getSymptom();
        List<PetIssue> getPetIssue();
        List<Medicine> getMedicine();
        common.Entities.Appointment getAppointment(int appointmentID);
        common.Entities.Appointment editAppointment(int appointmentID, common.Entities.Appointment editedAppointment);
        common.Entities.Appointment createAppointment(common.Entities.Appointment creatingAppointment);
    }
}
