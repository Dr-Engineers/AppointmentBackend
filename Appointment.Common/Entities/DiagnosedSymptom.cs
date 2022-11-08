using Appointment.common.Entities.Preset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.common.Entities
{
    public class DiagnosedSymptom
    {
        public int DiagnosedSymptomID { get; set; }
        public Symptom Symptom { get; set; }
    }
}
