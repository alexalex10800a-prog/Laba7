using DAL7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL7.models
{
    public class DepartmentDTO 

    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        
        public DepartmentDTO() { }
        public DepartmentDTO(department d)
        {
            ID = d.department_code;
            DepartmentName = d.department_name;
        }
    }
}
