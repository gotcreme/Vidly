﻿using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string DrivingLicense { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
    }
}