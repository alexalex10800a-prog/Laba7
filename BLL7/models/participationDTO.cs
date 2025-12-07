using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.models
{
    public class ParticipationDTO
    {
        public string Status { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectCode { get; set; }

        // Navigation properties for display
        public string EmployeeName { get; set; }
        public string ProjectInfo { get; set; }
        public string EmployeeSpecialty { get; set; }
    }
}
