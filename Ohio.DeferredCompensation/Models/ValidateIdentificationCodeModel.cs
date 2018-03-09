/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.ComponentModel.DataAnnotations;

namespace Ohio.DeferredCompensation.Models
{
    public class ValidateIdentificationCodeModel
    {
        [Required]
        public string Code { get; set; }
    }
}