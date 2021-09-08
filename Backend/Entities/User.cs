using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class User : IId
    {
        public int Id { get; set;}
        [StringLength(50)]
        public string FullName { get; set; }
        [StringLength(11)]
        public string Cedula { get; set; }
        [StringLength(5)]
        public string Gender { get; set; }
        public DateTime BirthDate{ get; set; }
        [StringLength(50)]
        public string Position { get; set; }
        [StringLength(50)]
        public string ImmediateSupervisor { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
