using OvulaeShared.Enums.ModuleEnums;
using OvulaeShared.ViewModel.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Services.Module.OvulationServices
{
    public interface IOvulationService
    {
        public List<ModulePhaseDataViewModel> GetAllPhasesData();

        public ModulePhaseDataViewModel GetCurrentPhaseData(int currentCycleDay);

        public ModulePhaseDetailsViewModel GetCurrentPhaseDetails(int currentCycleDay);

        public ModulePhaseDataViewModel GetPhaseData(OvulationPhase phase);

        public List<ModulePhaseDataViewModel> GetAllOvulationData();

        public ModulePhaseDetailsViewModel GetCurrentPhaseDetailsByPhase(OvulationPhase phase);
    }
}
