using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;
using TooltipIcons.Config;

namespace TooltipIcons
{
    public class TooltipIcons : Mod
	{
        public override void Load()
        {
            foreach (string fileName in GetFileNames())
            {
                if (fileName.StartsWith("Icons/") && fileName.EndsWith(".rawimg"))
                {
                    string name = fileName.Replace("Icons/", "").Replace(".rawimg", "");
                    IconItem item = new(name, "TooltipIcons/" + fileName.Replace(".rawimg", ""));
                    AddContent(item);
                }
            }
        }
    }
}