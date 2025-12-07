using DAL7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.models
{
    public class SpecialtyDTO 

    {
        public int ID { get; set; }
        public string SpecialtyName { get; set; }

        public SpecialtyDTO() { }
        public SpecialtyDTO(specialty s)
        {
            ID = s.specialty_code;
            SpecialtyName = s.specialty_name;
        }
        
    }
}
