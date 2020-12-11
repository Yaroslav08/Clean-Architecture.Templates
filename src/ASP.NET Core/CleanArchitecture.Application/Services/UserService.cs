using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels.User;
using CleanArchitecture.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public UserService(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }

        public async Task<UserViewModel> GetUserById(int id)
        {
            return mapper.Map<UserViewModel>(await unitOfWork.UserRepository.GetByWhereAsync(d => d.Id == id));
        }
    }
}