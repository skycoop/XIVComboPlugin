using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum MNKFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Fury Combo", "Replaces Bootshine, True Strike, and Snap Punch when no Fury charges are available", 20)]
        FuryCombo = 1 << 0,

        [CustomComboInfo("Perfect Balance on Masterful Blitz", "Replaces Masterful Blitz with Perfect Balance when no Blitz moves are available", 20)]
        PerfectBlitz = 1 << 1,
    }
}
