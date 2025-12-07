using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.models
{
    public class ContractDTO
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Cost { get; set; }
        public string Client { get; set; }
        public int LeaderCode { get; set; }
        public string LeaderName { get; set; } // For display purposes
    }

}
