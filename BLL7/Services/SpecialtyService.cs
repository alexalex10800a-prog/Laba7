using BLL7.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL7;

namespace BLL7.Services
{
    public class SpecialtyService
    {
        private readonly Model1 _context;

        public SpecialtyService()
        {
            _context = new Model1();
        }

        public List<SpecialtyDTO> GetAllSpecialties()
        {
            return _context.specialties
                .Select(s => new SpecialtyDTO
                {
                    ID = s.specialty_code,
                    SpecialtyName = s.specialty_name
                })
                .ToList();
        }
    }
}
