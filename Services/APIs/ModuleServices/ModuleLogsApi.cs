using Newtonsoft.Json;
using OvulaeShared.Enums.Errors;
using OvulaeShared.Helpers.API;
using OvulaeShared.Helpers.CommonFunctions;
using OvulaeShared.Models.Menopause;
using OvulaeShared.Models.Ovulation;
using OvulaeShared.Models.PeriodTracker;
using OvulaeShared.Models.Pregnancy;
using OvulaeShared.Models.WebApi;
using OvulaeShared.Services.APIs.Interface;
using OvulaeShared.ViewModel.Shared;

namespace OvulaeShared.Services.APIs.ModuleServices
{
    public class ModuleLogsApi : BaseApiService, IModuleLogsApi
    {
        private readonly IWebInterfaceApiService _webAPI;

        public ModuleLogsApi()
        {
            _webAPI = new WebInterfaceApiService(OvulaeApiEndPoints.BASE_ADDRESS);
        }

        #region Pregnancy

        public async Task<PregnancyTrackerLog> GetPregnancyLogs(string userId)
        {
            try
            {
                var request = new SecureApiRequest
                {
                    UserId = userId,
                };
                var data = await _webAPI.PostDataObject<PregnancyTrackerLog>(OvulaeApiEndPoints.MODULE_LOGS.GET_PREGNANCY_LOGS, request);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[PregnancyLogs] Error: {ex.Message}");
                return new PregnancyTrackerLog();
            }
        }

        public async Task<GenericResult> UpdatePregnancyLogEntry(string userId, PregnancyLogEntryItem pregnancyLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = pregnancyLog
                };

                var jsonPayload = JsonConvert.SerializeObject(dto);

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_PREGNANCY_LOG_ENTRY, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update pregnancy log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        public async Task<GenericResult> UpdatePregnancyLogEntryDR(string userId, PregnancyLogEntryItem pregnancyLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = pregnancyLog
                };

                var jsonPayload = JsonConvert.SerializeObject(dto);

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_PREGNANCY_LOG_ENTRY_DR, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update pregnancy log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        public async Task<GenericResult> UpdateBabyDetails(string userId, List<BabyDetailsLog> babyLogs)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = babyLogs
                };

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_BABY_DETAILS, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update baby details: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        #endregion

        #region Period

        public async Task<PeriodTrackerLog> GetPeriodLogs(string userId)
        {
            try
            {
                var request = new SecureApiRequest
                {
                    UserId = userId,
                };
                var data = await _webAPI.PostDataObject<PeriodTrackerLog>(OvulaeApiEndPoints.MODULE_LOGS.GET_PERIOD_LOGS, request);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[PeriodLogs] Error: {ex.Message}");
                return new PeriodTrackerLog();
            }
        }

        public async Task<GenericResult> UpdatePeriodLogEntry(string userId, PeriodLogEntry periodLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = periodLog
                };

                var jsonPayload = JsonConvert.SerializeObject(dto);

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_PERIOD_LOG_ENTRY, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update period log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        public async Task<GenericResult> UpdatePeriodLogEntryDR(string userId, PeriodLogEntry periodLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = periodLog
                };

                var jsonPayload = JsonConvert.SerializeObject(dto);

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_PERIOD_LOG_ENTRY_DR, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update period log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        #endregion

        #region Ovulation

        public async Task<OvulationTrackerLog> GetOvulationLogs(string userId)
        {
            try
            {
                var request = new SecureApiRequest
                {
                    UserId = userId,
                };
                var data = await _webAPI.PostDataObject<OvulationTrackerLog>(OvulaeApiEndPoints.MODULE_LOGS.GET_OVULATION_LOGS, request);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[OvulationLogs] Error: {ex.Message}");
                return new OvulationTrackerLog();
            }
        }

        public async Task<GenericResult> UpdateOvulationLogEntry(string userId, OvulationCycleLog ovulationLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = ovulationLog
                };

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_OVULATION_LOG_ENTRY, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update ovulation log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        public async Task<GenericResult> UpdateOvulationLogEntryDR(string userId, OvulationCycleLog ovulationLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = ovulationLog
                };

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_OVULATION_LOG_ENTRY_DR, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update ovulation log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        #endregion

        #region Menopause

        public async Task<MenopauseTrackerLog> GetMenopauseLogs(string userId)
        {
            try
            {
                var request = new SecureApiRequest
                {
                    UserId = userId,
                };
                
                var jsonPayload = JsonConvert.SerializeObject(request);

                var data = await _webAPI.PostDataObject<MenopauseTrackerLog>(OvulaeApiEndPoints.MODULE_LOGS.GET_MENOPAUSE_LOGS, request);
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[MenopauseLogs] Error: {ex.Message}");
                return new MenopauseTrackerLog();
            }
        }

        public async Task<GenericResult> UpdateMenopauseLogEntry(string userId, MenopauseLogEntry menopauseLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = menopauseLog,
                };

                var jsonPayload = JsonConvert.SerializeObject(dto);

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_MENOPAUSE_LOG_ENTRY, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update menopause log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        public async Task<GenericResult> UpdateMenopauseLogEntryDR(string userId, MenopauseLogEntry menopauseLog)
        {
            try
            {
                var dto = new SecureApiRequest
                {
                    UserId = userId,
                    ModelData = menopauseLog,
                };

                var jsonPayload = JsonConvert.SerializeObject(dto);

                return await _webAPI.PostData(OvulaeApiEndPoints.MODULE_LOGS.UPDATE_MENOPAUSE_LOG_ENTRY_DR, dto);
            }
            catch (Exception ex)
            {
                return new GenericResult
                {
                    Success = false,
                    Message = $"Failed to update menopause log entry: {ex.Message}",
                    ErrorTypes = { ErrorTypes.EXCEPTION_ERROR }
                };
            }
        }

        #endregion
    }
}
