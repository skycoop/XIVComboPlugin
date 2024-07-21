using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum NINFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Armor Crush Combo", "Replace Armor Crush with its combo chain", 30)]
        ArmorCrushCombo = 1 << 0,

        [CustomComboInfo("Aeolian Edge Combo", "Replace Aeolian Edge with its combo chain", 30)]
        AeolianEdgeCombo = 1 << 1,

        [CustomComboInfo("Hakke Mujinsatsu Combo", "Replace Hakke Mujinsatsu with its combo chain", 30)]
        HakkeMujinsatsuCombo = 1 << 2,
    }
}
