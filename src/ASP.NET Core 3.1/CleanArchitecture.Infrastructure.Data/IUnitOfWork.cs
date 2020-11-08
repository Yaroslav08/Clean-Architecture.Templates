using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitecture.Infrastructure.Data
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
    }
}