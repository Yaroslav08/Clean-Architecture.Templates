﻿using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitecture.Application.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
    }
}