using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.ModuleEnums;
using OvulaeShared.ViewModel.Module;

namespace OvulaeShared.Services.Module.PeriodTrackerServices
{
    public interface IPeriodTrackerService
    {
        public OvulationPhase GetOvulationPhase(int currentCycleDay);

        public ModulePhaseDataViewModel GetCurrentPhaseData(int currentCycleDay);

        public ModulePhaseDataViewModel GetPhaseData(OvulationPhase phase);

        public List<ModulePhaseDataViewModel> GetAllPhaseData();

        public ModulePhaseDetailsViewModel GetCurrentPhaseDetails(int currentCycleDay);

        public ModulePhaseDetailsViewModel GetCurrentPhaseDetailsByPhase(OvulationPhase phase);
    }
}
