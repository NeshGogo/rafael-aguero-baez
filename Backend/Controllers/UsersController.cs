using AutoMapper;
using Backend.DTOs;
using Backend.Entities;
using Backend.Services.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : CustomControllerBase<User>
    {
        public UsersController(IUserService service, IMapper mapper)
            : base(service, mapper) {}

        [HttpGet]
        public async Task<ActionResult<List<UserDTO>>> Get()
        {
            return await Get<UserDTO>();
        }

        [HttpGet("{id:int}", Name = "GetUser")]
        public async Task<ActionResult<UserDTO>> Get(int id)
        {
            return await Get<UserDTO>(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateUserDTO createUserDTO)
        {
            return await Post<UserDTO, CreateUserDTO>(createUserDTO, "GetUser");
        }
    }
}
