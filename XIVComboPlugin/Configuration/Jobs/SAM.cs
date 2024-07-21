using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum SAMFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Yukikaze Combo", "Replace Yukikaze with its combo chain", 34)]
        YukikazeCombo = 1 << 0,

        [CustomComboInfo("Gekko Combo", "Replace Gekko with its combo chain", 34)]
        GekkoCombo = 1 << 1,

        [CustomComboInfo("Kasha Combo", "Replace Kasha with its combo chain", 34)]
        KashaCombo = 1 << 2,

        [CustomComboInfo("Mangetsu Combo", "Replace Mangetsu with its combo chain", 34)]
        MangetsuCombo = 1 << 3,

        [CustomComboInfo("Oka Combo", "Replace Oka with its combo chain", 34)]
        OkaCombo = 1 << 4,

        [CustomComboInfo("Iaijutsu into Tsubame", "Replace Iaijutsu with Tsubame after using an Iaijutsu", 34)]
        TsubameCombo = 1 << 5,
    }
}
