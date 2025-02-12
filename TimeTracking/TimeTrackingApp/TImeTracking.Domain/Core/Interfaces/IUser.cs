﻿using System;
using System.Collections.Generic;
using System.Text;
using TImeTracking.Domain.Core.Entities;

namespace TImeTracking.Domain.Core.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        int Id { get; set; }
        void DeactivateProfile(User user);
        void ActivateProfile(User user);
    }
}
