using CleanArchitecture.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUserById(int id);
    }
}