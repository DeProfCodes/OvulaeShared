using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Tips
{
    public class TipItem
    {
        [Key]
        public int TipId { get; set; }

        public int TipGroupId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public StatusType Status { get; set; }

        public DateTime CreateData { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
