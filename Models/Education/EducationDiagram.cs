using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OvulaeShared.Models.Education
{
    public class EducationDiagram
    {
        public int Id { get; set; }  
        public int EducationBookId { get; set; }  

        public string Heading { get; set; }
        public string FileName { get; set; }

    }
}
