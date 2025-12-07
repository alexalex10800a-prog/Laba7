using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.models
{
    public class EmployeeTransferDTO
    {
        public int EmployeeId { get; set; }
        public int NewDepartmentId { get; set; }
        public string Reason { get; set; } // Optional: reason for transfer
        public DateTime EffectiveDate { get; set; }

    }
}
