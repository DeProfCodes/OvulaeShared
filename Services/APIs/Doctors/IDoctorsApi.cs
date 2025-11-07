using OvulaeShared.Models.Affiliate;
using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Affiliates;
using OvulaeShared.ViewModel.Doctor;
using OvulaeShared.ViewModel.User;

namespace OvulaeShared.Services.APIs.Doctors
{
    public interface IDoctorsApi
    {
        public Task<List<UserDoctorPatientDetailsViewModel>> GetDoctorAllPatientsList(SecureApiRequest secureDto);

        public Task<DoctorDashboardViewModel> GetDoctorDashboardDetails(SecureApiRequest secureDto);

        public Task<PatientProfileViewModel> GetDoctorsPatientProfile(DoctorPatientRequest patientInfoReqDto);
    }
}
