using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.ViewModel.Doctor
{
    public class DoctorPatientRequest
    {
        public string DoctorUserId { get; set; }

        public string DoctorEmail { get; set; }

        public string PatientUserId { get; set; }

        public string PatientEmail { get; set; }
    }
}
