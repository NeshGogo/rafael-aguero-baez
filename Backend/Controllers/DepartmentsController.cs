using AutoMapper;
using Backend.DTOs;
using Backend.Entities;
using Backend.Services.Deparments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : CustomControllerBase<Department>
    {
        public DepartmentsController(IDepartmentService service, IMapper mapper)
            : base(service, mapper) { }

        [HttpGet]
        public async Task<ActionResult<List<DepartmentDTO>>> Get()
        {
            return await Get<DepartmentDTO>();
        }

        [HttpGet("{id:int}", Name = "GetDepartment")]
        public async Task<ActionResult<DepartmentDTO>> Get(int id)
        {
            return await Get<DepartmentDTO>(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateDepartmentDTO createDepartmentDTO)
        {
            return await Post<DepartmentDTO, CreateDepartmentDTO>(createDepartmentDTO, "GetDepartment");
        }
    }
}
