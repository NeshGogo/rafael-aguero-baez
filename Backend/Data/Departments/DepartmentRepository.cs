using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data.Deparments
{
    public class DepartmentRepository : SQLRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
