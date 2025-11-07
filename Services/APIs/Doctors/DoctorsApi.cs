using OvulaeShared.Models.WebApi;
using OvulaeShared.ViewModel.Affiliates;
using OvulaeShared.ViewModel.Doctor;
using OvulaeShared.ViewModel.User;
using Endpoints = OvulaeShared.Helpers.API.OvulaeApiEndPoints.DOCTORS;

namespace OvulaeShared.Services.APIs.Doctors
{
    public class DoctorsApi : BaseApiService, IDoctorsApi
    {
        public DoctorsApi()
        {
            
        }

        #region CRUD - CREATE


        #endregion

        #region CRUD - READ

        public async Task<DoctorDashboardViewModel> GetDoctorDashboardDetails(SecureApiRequest secureDto)
        {
            try
            {
                var data = await _webAPI.PostDataObject<DoctorDashboardViewModel>(Endpoints.GET_DOCTORS_DASHBOARD, secureDto);

                return data;
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<UserDoctorPatientDetailsViewModel>> GetDoctorAllPatientsList(SecureApiRequest secureDto)
        {
            try
            {
                var data = await _webAPI.PostDataObject<List<UserDoctorPatientDetailsViewModel>>(Endpoints.GET_DOCTORS_ALL_PATIENTS, secureDto);

                return data;
            }
            catch
            {
                return null;
            }
        }

        public async Task<PatientProfileViewModel> GetDoctorsPatientProfile(DoctorPatientRequest patientInfoReqDto)
        {
            try
            {
                var data = await _webAPI.PostDataObject<PatientProfileViewModel>(Endpoints.GET_DOCTORS_PATIENT_DETAILS, patientInfoReqDto);

                return data;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region CRUD - UPDATE

        #endregion

    }
}
