using AutoMapper;
using Backend.DTOs;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<CreateUserDTO, User>();

            CreateMap<DepartmentDTO, Department>().ReverseMap();
            CreateMap<CreateDepartmentDTO, Department>();
        }
    }
}
