using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.models
{
    // In BLL layer - EmployeeProjectsDTO.cs
    public class EmployeeProjectsDTO
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string SpecialtyName { get; set; }
        public string DepartmentName { get; set; }
        public int ProjectCode { get; set; }
        public string ParticipationStatus { get; set; }
    }
}
