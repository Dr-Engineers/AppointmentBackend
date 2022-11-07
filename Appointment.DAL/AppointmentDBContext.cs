using Appointment.Common.Entity;

using System.Data.Entity;

namespace Appointment.DAL
{
    public class AppointmentDBContext: DbContext
    {

        public AppointmentDBContext(): base("name=DefaultConnection")
        {

        }

        public DbSet<Common.Entity.Appointment> Appointments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Vital> Vitals { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<RecommendedClinic> RecommendedClinics { get; set; }

    }
}
