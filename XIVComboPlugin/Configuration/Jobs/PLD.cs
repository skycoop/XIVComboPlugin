using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum PLDFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Royal Authority Combo", "Replace Royal Authority/Rage of Halone with its combo chain", 19)]
        RoyalAuthorityCombo = 1 << 0,

        [CustomComboInfo("Prominence Combo", "Replace Prominence with its combo chain", 19)]
        ProminenceCombo = 1 << 1,

        [CustomComboInfo("Requiescat/Imperator Confiteor", "Replace Requiescat/Imperator with Confiteor while under the effect of Requiescat", 19)]
        RequiescatCombo = 1 << 2,
    }
}
