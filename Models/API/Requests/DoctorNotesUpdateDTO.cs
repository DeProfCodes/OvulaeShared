using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OvulaeShared.Enums.Affiliate;

namespace OvulaeShared.Models.API.Requests
{
    public class DoctorNotesUpdateDTO
    {
        public DoctorNotesUpdateType NotesType { get; set; }

        public string DoctorUserId { get; set; }

        public int ModuleLogId { get; set; }

        public int EntryId { get; set; }

        public string DoctorsNotes { get; set; }
    }
}
