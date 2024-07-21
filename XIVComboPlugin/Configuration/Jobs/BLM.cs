using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum BLMFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Enochian Stance Switcher", "Change Fire 4, Blizzard 4, Flare, and Freeze to the appropriate element depending on stance", 25)]
        EnochianFeature = 1 << 0,
    }
}
