using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Pregnancy
{
    public class PregnancyWeekContent
    {
        public int Id { get; set; }

        public int Week { get; set; }
        public string WeekDescription { get; set; }
        public string PregnancyHighlight { get; set; }
        public string PregnancyKeyFeatures { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }

        public StatusType Status { get; set; }
        public DateTime CreateData { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
