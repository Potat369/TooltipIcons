using Terraria.ModLoader;

namespace TooltipIcons
{
    [Autoload(false)]
    internal class IconItem(string name, string texturePath) : ModItem
    {
        protected override bool CloneNewInstances => true;
        public override string Texture => texturePath;

        public override string Name => name;
    }
}
