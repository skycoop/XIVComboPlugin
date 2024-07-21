using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum PCTFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Additive to Subtractive Combo", "Replace Additive combo with Subtractive combo when Subtractive Pallet is active", 42)]
        SubtractivePallet = 1 << 0,

        [CustomComboInfo("Motifs and Muses", "Replace Motifs with their relevant Muses", 42)]
        MotifMuseFeature = 1 << 1,

        [CustomComboInfo("Landscape and Steel follow-ups", "Additionally replace Landscape Motif with Star Prism and Weapon Motif with Hammer Stamp when appropriate", 42)]
        MuseCombo = 1 << 2,

        [CustomComboInfo("Holy White to Comet Black", "Replace Holy in White with Comet in Black when Monochrome Tones is active", 42)]
        HolyWhiteCombo = 1 << 3,
    }
}
