using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHF_Manager.Data
{
    public class CraftingTable
    {
        public string name { get; set; }
        public long start { get; set; }
        public long end { get; set; }
        public List<CraftingTableEntry> entries;
        public CraftingTable(string name, uint start, uint end)
        {
            this.name = name;
            this.start = start;
            this.end = end;
            entries = new();
        }

        public void init(bool force = false)
        {
            if (force)
            {
                entries = new();
            }

            if (entries.Count != 0)
            {
                return;
            }

            BinaryReader br = StaticData.GetMhfdat().GetMhfdatReader();

            br.BaseStream.Position = start;
            this.start = br.ReadUInt32();
            br.BaseStream.Position = end;
            this.end = br.ReadUInt32();

            br.BaseStream.Position = start;

            while (br.BaseStream.Position < end)
            {
                entries.Add(new CraftingTableEntry(br));
            }
        }

        public List<CraftingTableEntry> GetEntries()
        {
            init();

            return entries;
        }
    }
}
