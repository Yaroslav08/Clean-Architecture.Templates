using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

    }
}