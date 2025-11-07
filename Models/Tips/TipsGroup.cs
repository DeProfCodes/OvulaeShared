using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Tips
{
    public class TipsGroup
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Weeks { get; set; }

        public StatusType Status { get; set; }

        public string TipFromDoctor { get; set; }

        public DateTime CreateData { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
