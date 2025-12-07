using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.models
{
    public class SpecialtyAssignmentDTO
    {
        public int EmployeeId { get; set; }
        public int SpecialtyId { get; set; }
        public int AssignedByManagerId { get; set; } // Who is making the assignment

    }
}
