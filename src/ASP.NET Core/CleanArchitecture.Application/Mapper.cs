using AutoMapper;
using CleanArchitecture.Application.ViewModels.User;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitecture.Application
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserViewModel>();
        }
    }
}