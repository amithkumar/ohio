/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class SignupModel
    {
        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string SSN { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string AccountRecoveryEmailId { get; set; }

        [Required]
        public string AccountRecoveryPhone { get; set; }

        [Required]
        public bool AgreementAccepted { get; set; }
    }
}