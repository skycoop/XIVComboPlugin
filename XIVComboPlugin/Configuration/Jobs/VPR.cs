using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum VPRFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Death Rattle Finisher", "Replace Steel Fangs/Dread Fangs with Death Rattle when available", 41)]
        DeathRattleCombo = 1 << 0,

        [CustomComboInfo("Last Lash Finisher", "Replace Steel Maw/Dread Maw with Last Lash when available", 41)]
        LastLashCombo = 1 << 1,

        [CustomComboInfo("Generational Legacy", "Legacy moves replace Generation moves when usable", 41)]
        LegacyCombo = 1 << 2,
    }
}
