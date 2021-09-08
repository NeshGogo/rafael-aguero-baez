using Backend.Data.Users;
using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public async Task<User> AddAsync(User user)
        {
            return await repository.AddAsync(user);
        }

        public async Task<List<User>> GetAsync()
        {
            return await repository.GetAsync("Department");
        }

        public async Task<User> GetAsync(int id)
        {
            return await repository.GetAsync(id);
        }
    }
}
