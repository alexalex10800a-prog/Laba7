using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL7.Entities
{
    // In DAL layer
    public class EmployeeProjectsReport
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string SpecialtyName { get; set; }
        public string DepartmentName { get; set; }
        public int ProjectCode { get; set; }      // New
        public string ParticipationStatus { get; set; } // New
    }
}
