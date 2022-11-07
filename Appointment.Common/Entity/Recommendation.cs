using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment.Common.Entity
{
    public class Recommendation
    {
        public int RecommendationId { get; set; }

        public List<RecommendedClinic> Recommendation_Clinic { get; set; }
        public List<RecommendedDoctors> Recommendation_Doc { get; set; }
        public string Comments { get; set; }
    }
}
