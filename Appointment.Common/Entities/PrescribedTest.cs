using Appointment.common.Entities.Preset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.common.Entities
{
    public class PrescribedTest
    {
        public int PrescribedTestID { get; set; }
        public Test Test { get; set; }
    }
}
