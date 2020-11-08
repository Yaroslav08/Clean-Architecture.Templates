using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitecture.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUserRepository userRepository;

        public UnitOfWork(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public IUserRepository UserRepository => userRepository;
    }
}