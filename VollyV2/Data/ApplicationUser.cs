﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using VollyV2.Data.Volly;

namespace VollyV2.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<Application> Applications { get; set; }
        public string ProfileImage { get; set; }
        public List<VolunteerHours> VolunteerHours { get; set; }
        public Company Company { get; set; }
        public List<UserCause> Causes { get; set; }
    }
}
