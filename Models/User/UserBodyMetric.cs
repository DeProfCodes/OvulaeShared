using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Models.User
{
    public class UserBodyMetric
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int Year { get; set; }

        public double Weight { get; set; }

        public string WeightUnit { get; set; }

        public double Height { get; set; }

        public string HeightUnit { get; set; }

        public string BloodGroup { get; set; }

        public string RhFactor { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

    }
}
