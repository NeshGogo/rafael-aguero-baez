using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Cedula { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Position { get; set; }
        public string ImmediateSupervisor { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
