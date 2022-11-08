using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.DAL
{
    public class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext() : base("name=DefaultString")
        {

        }
        public DbSet<common.Entities.Appointment> Appointments { get; set; }
        public DbSet<common.Entities.Preset.Clinic> Clinics { get; set; }
        public DbSet<common.Entities.Preset.Medicine> Medicines { get; set; }
        public DbSet<common.Entities.Preset.PetIssue> PetIssues { get; set; }
        public DbSet<common.Entities.Preset.Symptom> Symptoms { get; set; }
        public DbSet<common.Entities.Preset.Test> Tests { get; set; }
    }
}
