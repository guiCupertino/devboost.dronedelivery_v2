﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.DroneDelivery.Domain.Entities
{
    public class User
    {
        public User(int id, string username, string password, string role)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
    }
}
