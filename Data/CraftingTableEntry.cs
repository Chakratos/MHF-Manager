using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHF_Manager.Data
{
    public class CraftingTableEntry
    {
		[Serializable]
		public struct CraftingTableStruct
        {
            public byte TypeClass;
            public byte UnkFlag;
            public ushort EquipId;
            public ushort FirstItemId;
            public ushort FirstAmount;
            public ushort Unk0;
            public ushort Unk1;
            public ushort SecondItemId;
            public ushort SecondAmount;
            public ushort Unk3;
            public ushort Unk4;
            public ushort ThirdItemId;
            public ushort ThirdAmount;
            public ushort Unk5;
            public ushort Unk6;
            public ushort ForthItemId;
            public ushort ForthAmount;
            public ushort Unk7;
            public ushort Unk8;
            public ushort Unk9;
            public ushort Unk10;
            public ushort Unk11;
            public ushort Unk12;
            public ushort IsPremium;
            public ushort Unk14;
            public ushort Unk15;
            public ushort Unk16;
            public ushort Unk17;
            public ushort Unk18;
        }

        public long Position { get; set; }
        public CraftingTableStruct data = new();

        public void test()
        {
			string jsonString = JsonConvert.SerializeObject(this);
            try
            {
				CraftingTableEntry jsonDeserialized = JsonConvert.DeserializeObject<CraftingTableEntry>(jsonString);
                int i = 1;
			} catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
			
		}

        public CraftingTableEntry()
        {
        }
		public CraftingTableEntry(CraftingTableEntry entry)
        {
            Position = entry.Position;

            data.TypeClass = entry.data.TypeClass;
			data.UnkFlag = entry.data.UnkFlag;
            data.EquipId = entry.data.EquipId;
            data.FirstItemId = entry.data.FirstItemId;
            data.FirstAmount = entry.data.FirstAmount;
            data.Unk0 = entry.data.Unk0;
            data.Unk1 = entry.data.Unk1;
            data.SecondItemId = entry.data.SecondItemId;
            data.SecondAmount = entry.data.SecondAmount;
            data.Unk3 = entry.data.Unk3;
            data.Unk4 = entry.data.Unk4;
            data.ThirdItemId = entry.data.ThirdItemId;
            data.ThirdAmount = entry.data.ThirdAmount;
            data.Unk5 = entry.data.Unk5;
            data.Unk6 = entry.data.Unk6;
            data.ForthItemId = entry.data.ForthItemId;
            data.ForthAmount = entry.data.ForthAmount;
            data.Unk7 = entry.data.Unk7;
            data.Unk8 = entry.data.Unk8;
            data.Unk9 = entry.data.Unk9;
            data.Unk10 = entry.data.Unk10;
            data.Unk11 = entry.data.Unk11;
            data.Unk12 = entry.data.Unk12;
            data.IsPremium = entry.data.IsPremium;
            data.Unk14 = entry.data.Unk14;
            data.Unk15 = entry.data.Unk15;
            data.Unk16 = entry.data.Unk16;
            data.Unk17 = entry.data.Unk17;
            data.Unk18 = entry.data.Unk18;
        }

		public CraftingTableEntry(BinaryReader reader)
        {
            Position = reader.BaseStream.Position;

            data.TypeClass = (byte)reader.ReadByte();
            data.UnkFlag = (byte)reader.ReadByte();
            data.EquipId = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.FirstItemId = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.FirstAmount = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk0 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk1 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.SecondItemId = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.SecondAmount = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk3 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk4 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.ThirdItemId = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.ThirdAmount = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk5 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk6 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.ForthItemId = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.ForthAmount = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk7 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk8 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk9 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk10 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk11 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk12 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.IsPremium = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk14 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk15 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk16 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk17 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
            data.Unk18 = BitConverter.ToUInt16(reader.ReadBytes(2), 0);
        }

        public bool HasChanged(CraftingTableEntry after)
        {
			return !(data.TypeClass == after.data.TypeClass &&
		             data.UnkFlag == after.data.UnkFlag &&
		             data.EquipId == after.data.EquipId &&
		             data.FirstItemId == after.data.FirstItemId &&
		             data.FirstAmount == after.data.FirstAmount &&
		             data.Unk0 == after.data.Unk0 &&
		             data.Unk1 == after.data.Unk1 &&
		             data.SecondItemId == after.data.SecondItemId &&
		             data.SecondAmount == after.data.SecondAmount &&
		             data.Unk3 == after.data.Unk3 &&
		             data.Unk4 == after.data.Unk4 &&
		             data.ThirdItemId == after.data.ThirdItemId &&
		             data.ThirdAmount == after.data.ThirdAmount &&
		             data.Unk5 == after.data.Unk5 &&
		             data.Unk6 == after.data.Unk6 &&
		             data.ForthItemId == after.data.ForthItemId &&
		             data.ForthAmount == after.data.ForthAmount &&
		             data.Unk7 == after.data.Unk7 &&
		             data.Unk8 == after.data.Unk8 &&
		             data.Unk9 == after.data.Unk9 &&
		             data.Unk10 == after.data.Unk10 &&
		             data.Unk11 == after.data.Unk11 &&
		             data.Unk12 == after.data.Unk12 &&
		             data.IsPremium == after.data.IsPremium &&
		             data.Unk14 == after.data.Unk14 &&
		             data.Unk15 == after.data.Unk15 &&
		             data.Unk16 == after.data.Unk16 &&
		             data.Unk17 == after.data.Unk17 &&
		             data.Unk18 == after.data.Unk18);
		}

        public void CopyTo(CraftingTableEntry destination)
        {
            destination.data.TypeClass = data.TypeClass;
			destination.data.UnkFlag = data.UnkFlag;
            destination.data.EquipId = data.EquipId;
            destination.data.FirstItemId = data.FirstItemId;
            destination.data.FirstAmount = data.FirstAmount;
            destination.data.Unk0 = data.Unk0;
            destination.data.Unk1 = data.Unk1;
            destination.data.SecondItemId = data.SecondItemId;
            destination.data.SecondAmount = data.SecondAmount;
            destination.data.Unk3 = data.Unk3;
            destination.data.Unk4 = data.Unk4;
            destination.data.ThirdItemId = data.ThirdItemId;
            destination.data.ThirdAmount = data.ThirdAmount;
            destination.data.Unk5 = data.Unk5;
            destination.data.Unk6 = data.Unk6;
            destination.data.ForthItemId = data.ForthItemId;
            destination.data.ForthAmount = data.ForthAmount;
            destination.data.Unk7 = data.Unk7;
            destination.data.Unk8 = data.Unk8;
            destination.data.Unk9 = data.Unk9;
            destination.data.Unk10 = data.Unk10;
            destination.data.Unk11 = data.Unk11;
            destination.data.Unk12 = data.Unk12;
            destination.data.IsPremium = data.IsPremium;
            destination.data.Unk14 = data.Unk14;
            destination.data.Unk15 = data.Unk15;
            destination.data.Unk16 = data.Unk16;
            destination.data.Unk17 = data.Unk17;
            destination.data.Unk18 = data.Unk18;
        }

        public void writeToStream(BinaryWriter writer)
        {
			writer.Seek((int)Position, SeekOrigin.Begin);
			writer.Write(data.TypeClass);
			writer.Write(data.UnkFlag);
			writer.Write(data.EquipId);
			writer.Write(data.FirstItemId);
			writer.Write(data.FirstAmount);
			writer.Write(data.Unk0);
			writer.Write(data.Unk1);
			writer.Write(data.SecondItemId);
			writer.Write(data.SecondAmount);
			writer.Write(data.Unk3);
			writer.Write(data.Unk4);
			writer.Write(data.ThirdItemId);
			writer.Write(data.ThirdAmount);
			writer.Write(data.Unk5);
			writer.Write(data.Unk6);
			writer.Write(data.ForthItemId);
			writer.Write(data.ForthAmount);
			writer.Write(data.Unk7);
			writer.Write(data.Unk8);
			writer.Write(data.Unk9);
			writer.Write(data.Unk10);
			writer.Write(data.Unk11);
			writer.Write(data.Unk12);
			writer.Write(data.IsPremium);
			writer.Write(data.Unk14);
			writer.Write(data.Unk15);
			writer.Write(data.Unk16);
			writer.Write(data.Unk17);
			writer.Write(data.Unk18);
			writer.Flush();
		}
    }
}
