﻿using Personal_Task_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Task_Manager.Repositories.UserRepository
{
    public interface IUserRepository
    {
        public User Authenticate(string email, string password);
        public bool Signup(User user); 
        public bool CheckEmail(string email); 
    }
}
