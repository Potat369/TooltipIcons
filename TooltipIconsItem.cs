using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Terraria;
using Terraria.Graphics;
using Terraria.ModLoader;
using TooltipIcons.Config;

namespace TooltipIcons
{
    internal class TooltipIconsItem : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipline in tooltips)
            {
                string[] line = tooltipline.Text.Split('\n');
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == "")
                    {
                        continue;
                    }
                    if (ModContent.GetInstance<DebugConfig>().DebugMode)
                    {
                        line[i] = line[i].Insert(0, tooltipline.FullName + " ");
                        continue;
                    }
                    if (tooltipline.Name == "ItemName")
                    {
                        line[i] = line[i].Insert(0, $"[i/s{item.stack}:{item.netID}] ");
                        continue;
                    }
                    if (tooltipline.Name.StartsWith("Tooltip"))
                    {
                        line[i] = line[i].Insert(0, "[i:TooltipIcons/Tooltip] ");
                        continue;
                    }
                    line[i] = line[i].Insert(0, $"[i:TooltipIcons/{tooltipline.Name}] ");
                }
                tooltipline.Text = string.Join("\n", line);
            }
        }
    }
}
