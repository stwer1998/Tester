﻿using System;
using System.Collections.Generic;
using System.Text;
using TesterCore.Interface;

namespace TesterCore.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
