using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Status;

namespace OvulaeShared.Models.Symptoms
{
    public class SymptomsGroup
    {
        public int Id { get; set; }

        public string Type { get; set; }  

        public string Weeks { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public StatusType Status { get; set; }
    }
}
