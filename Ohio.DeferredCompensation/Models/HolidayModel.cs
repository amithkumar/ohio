/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System;

namespace Ohio.DeferredCompensation.Models
{
    public class HolidayModel
    {
        public string Title { get; set; }

        public DateTime DateClosed { get; set; }

        public DateTime DateProcessed { get; set; }
    }
}