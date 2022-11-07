using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Common.Entity
{
    public class Medicine
    {
        public int MedicineID { get; set; }
        public int MedID { get; set; }

        public int Days { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Night { get; set; }
        public bool BeforeFood { get; set; }
        public string Comments { get; set; }
    }
}
