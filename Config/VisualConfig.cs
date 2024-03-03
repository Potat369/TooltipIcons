using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace TooltipIcons.Config
{
    internal class VisualConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DefaultValue(true)]
        [BackgroundColor(55, 255, 99)]
        public bool WhiteSpace;
    }
}
