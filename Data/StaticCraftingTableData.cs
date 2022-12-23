using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHF_Manager.Data
{
    public static class StaticCraftingTableData
    {
        public static List<CraftingTable> CraftingTables = new List<CraftingTable> { 
            new CraftingTable("ArmorGCraftingTable", 0x5F4, 0x5F0),
            new CraftingTable("More2WeaponCraftingTable", 0x5F0, 0xB98),
            new CraftingTable("TransmogCraftingTable", 0xAB8, 0xAC0),
            new CraftingTable("MeleeWeaponCraftingTable", 0xAC0, 0xAC4),
            new CraftingTable("RangedWeaponCraftingTable", 0xAC4, 0x38),
            new CraftingTable("OtherWeaponCraftingTable", 0x38, 0x34),
            new CraftingTable("ArmorCraftingTable", 0x34, 0x8BC),

            };
    }
}
