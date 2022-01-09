using Microsoft.EntityFrameworkCore;
using PatientManagement.Application.Interfaces;
using PatientManagement.Models;
using PatientManagement.ViewModels;
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

        public async Task<ResponseModel<IEnumerable<User>>> GetUsersListAsync()
        {
            ResponseModel<IEnumerable<User>> response = new ResponseModel<IEnumerable<User>>();

            try
            {
                var users = await _context.Users.ToListAsync();
                response.Entity = users;
                response.status = true;
            }
            catch(Exception e)
            {
                response.status = false;
                response.ReturnMessage.Add(e.Message);
            }
            

            return response;
        }
    }
}
