
namespace OvulaeShared.Models.Extra
{
    public class MenstrualProfile
    {
        public int Id { get; set; }
        public DateTime LoggedDate { get; set; }
        public DateTime? LMP { get; set; }
        public int? CycleLength { get; set; }
        public int? PeriodLength { get; set; }
        public string Notes { get; set; }  // optional
    }
}
