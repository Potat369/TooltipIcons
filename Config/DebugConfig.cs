using Terraria.ModLoader.Config;

namespace TooltipIcons.Config
{
    internal class DebugConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [BackgroundColor(255, 55, 99)]
        public bool DebugMode;
    }
}
