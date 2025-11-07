using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Models.Shared
{
    public class UpdateHistory
    {
        public int Id { get; set; }

        public string ModuleName { get; set; }

        public string FeatureName { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}
