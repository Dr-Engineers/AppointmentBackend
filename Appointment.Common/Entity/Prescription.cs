using System.Collections.Generic;

namespace Appointment.Common.Entity
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public List<Medicine> PrescribedMedicines { get; set; }
    }
}
