using System.Collections.Generic;

namespace Appointment.Common.Entity
{
    public class Symptom
    {
        public int SymptomId { get; set; }

        public List<SymptomAssociation> SymptomIDs { get; set; }
    }
}
