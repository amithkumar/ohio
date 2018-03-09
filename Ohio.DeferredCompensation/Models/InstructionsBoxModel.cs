/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
using System.Collections.Generic;

namespace Ohio.DeferredCompensation.Models
{
    public class InstructionsBoxModel
    {
        public bool ShowCloseButton { get; set; }

        public IList<string> Instructions { get; set; }

        public string CssClass { get; set; }

        public InstructionsBoxModel(IList<string> instructions, string cssClass = null, bool showCloseButton = false)
        {
            Instructions = instructions;
            CssClass = cssClass;
            ShowCloseButton = showCloseButton;
        }
    }
}