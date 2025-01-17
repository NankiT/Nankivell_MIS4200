﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nankivell_MIS4200.Models
{
    public class UserDetails
    {
        
            [Required]
            public Guid ID { get; set; }
            
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }
            [Required]
            [Display(Name = "First Name")]
            public string firstName { get; set; }
            [Required]
            [Display(Name = "Last Name")]
            public string lastName { get; set; }
            [Display(Name = "Primary Phone")]
            [Phone]
            public string PhoneNumber { get; set; }
            
           
        
    }
}