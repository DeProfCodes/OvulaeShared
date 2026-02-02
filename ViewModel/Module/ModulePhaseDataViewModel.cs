using OvulaeShared.Enums.ModuleEnums;

namespace OvulaeShared.ViewModel.Module
{
    public class ModulePhaseDataViewModel
    {
        public OvulationPhase ModulePhase { get; set; }

        public MenopauseStage MenopauseStage { get; set; }

        public List<ModuleDashboardCard> PhaseHighlights { get; set; }

        public ModulePhaseDetailsViewModel PhaseDetails { get; set; }

        public string PhaseSummary { get; set; }
    }
}
