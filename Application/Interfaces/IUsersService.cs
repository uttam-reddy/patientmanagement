using PatientManagement.Models;
using PatientManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientManagement.Application.Interfaces
{
    public interface IUsersService
    {
        Task<ResponseModel<IEnumerable<User>>> GetUsersListAsync();
    }
}
