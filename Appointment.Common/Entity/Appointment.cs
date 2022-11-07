using System;
using System.Collections.Generic;

namespace Appointment.Common.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Status AppointmentStatus { get; set; }
        public List<PetIssueAssociation> PetIssues { get; set; }
        public Prescription Prescription { get; set; }
        public Recommendation Recommendation { get; set; }
        public Symptom Symptom { get; set; }
        public Test Test { get; set; }
        public Vital Vital { get; set; }
        public int PetId { get; set; }
        public int DoctorId { get; set; }
    }
}
