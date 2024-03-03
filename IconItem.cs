using Terraria.ModLoader;

namespace TooltipIcons
{
    [Autoload(false)]
    internal class IconItem : ModItem
    {
        private string name;
        private string texturePath;
        public IconItem(string name, string texturePath)
        {
            this.name = name;
            this.texturePath = texturePath;
        }
        protected override bool CloneNewInstances => true;
        public override string Texture => texturePath;

        public override string Name => name;
    }
}
