﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyInvestments.Model
{
    public class User{
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInformation()
        {
            
                return true;
            
        }
    }
}
