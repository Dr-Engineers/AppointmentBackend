using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.DAL
{
    public class AppointmentDbContext:DbContext
    {
        public AppointmentDbContext():base("name=DefaultString")
        {

        }
        public DbSet<common.Entities.Appointment> Appointments { get; set; }
    }
}
