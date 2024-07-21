using System;
using XIVComboPlugin;

namespace XIVCombo.Configuration.Jobs
{
    [Flags]
    public enum ASTFlags : ushort
    {
        None = 0,

        [CustomComboInfo("Astral/Umbral Draw on Play 1/2/3", "Play actions turn into Draw actions after playing a card, while keeping the the usual Play behavior", 33)]
        CardsOnDrawFeature = 1 << 0,
    }
}
