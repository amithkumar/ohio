/*
*  Copyright (c) 2018, TopCoder, Inc. All rights reserved.
*/
namespace Ohio.DeferredCompensation.Models
{
    public class TopIdentityPanelModel
    {
        public bool FixSpacing { get; set; }

        public bool ApplyXsXmClasses { get; set; }

        public string NavigationTab { get; set; }

        public TopIdentityPanelModel(bool fixSpacing = false, bool applyXsXmClasses = false, string navigationTab = null)
        {
            FixSpacing = fixSpacing;
            ApplyXsXmClasses = applyXsXmClasses;
            NavigationTab = navigationTab;
        }
    }
}