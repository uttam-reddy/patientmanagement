using Microsoft.EntityFrameworkCore;
using PatientManagement.Application.Interfaces;
using PatientManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Application.Services
{
    public class UserService : IUsersService
    {
        private readonly PMSContext _context;


        public UserService(PMSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersListAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}
