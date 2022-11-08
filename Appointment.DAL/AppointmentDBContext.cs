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
        public DbSet<common.Entities.Preset.Medicine> PreMedicine { get; set; }
        public DbSet<common.Entities.Preset.PetIssue> PrePetIssues { get; set; }
        public DbSet<common.Entities.Preset.Symptom> PreSymptoms { get; set; }
        public DbSet<common.Entities.Preset.Test> PreTests { get; set; }
        public DbSet<common.Entities.Preset.Clinic> PreClinics { get; set; }
    }
}
