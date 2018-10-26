﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VollyV2.Models;

namespace VollyV2.Data.Volly
{
    public class VolunteerHours
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [DisplayName("Organization Name")]
        public string OrganizationName { get; set; }
        [DisplayName("Date/Time")]
        public DateTime DateTime { get; set; }
        public Application Application { get; set; }
        public double Hours { get; set; }
    }
}
