using Backend.Data.Deparments;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Deparments
{
    public class DepartmentService: IDepartmentService
    {
        private readonly IDepartmentRepository repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Department> AddAsync(Department department)
        {
            return await repository.AddAsync(department);
        }

        public async Task<List<Department>> GetAsync()
        {
            return await repository.GetAsync();
        }

        public async Task<Department> GetAsync(int id)
        {
            return await repository.GetAsync(id);
        }
    }
}
