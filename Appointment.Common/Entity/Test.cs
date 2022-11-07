using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Common.Entity
{
    public class Test
    {
        public int TestId { get; set; }

        public List<TestAssociation> TestLists { get; set; }
    }
}
