﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LacunaMod.Buffs
{
    public class Buff_Retribution : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Retribution");
            Description.SetDefault(" 15% Increased outgoing damage"); ///////
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<LCPlr>().retribution = true;
            player.GetModPlayer<LCPlr>().BoostAllDamage(0.15f);
        }
    }
}
