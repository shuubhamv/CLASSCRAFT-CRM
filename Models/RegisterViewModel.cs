﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.ComponentModel.DataAnnotations;

//namespace CRMSystem.Models
//{
//    public class RegisterViewModel
//    {
//        [Required]
//        [EmailAddress]
//        [Display(Name = "Email")]
//        public string Email { get; set; }

//        [Required]
//        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
//        [DataType(DataType.Password)]
//        [Display(Name = "Password")]
//        public string Password { get; set; }

//        [DataType(DataType.Password)]
//        [Display(Name = "Confirm password")]
//        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
//        public string ConfirmPassword { get; set; }

//        [Required]
//        [Display(Name = "Role")]
//        public string Role { get; set; }  // Role selection for the user during registration
//    }
//}