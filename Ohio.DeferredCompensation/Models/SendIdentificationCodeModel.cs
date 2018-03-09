/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class SendIdentificationCodeModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string SendTo { get; set; }
    }
}