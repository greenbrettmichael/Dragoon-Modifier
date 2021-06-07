﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragoon_Modifier.Core.Memory.Battle {
    public class Character : BattleEntity {
        private readonly int _menuBlock;
        private readonly int _dragoonTurns;

        public byte Menu { get { return Emulator.ReadByte(_baseAddress - 0xA4); } set { Emulator.WriteByte(_baseAddress - 0xA4, value); } }
        public byte LV { get { return Emulator.ReadByte(_baseAddress - 0x4); } set { Emulator.WriteByte(_baseAddress - 0x4, value); } }
        public byte DLV { get { return Emulator.ReadByte(_baseAddress - 0x2); } set { Emulator.WriteByte(_baseAddress - 0x2, value); } }
        public byte Dragoon { get { return Emulator.ReadByte(_baseAddress + 0x7); } set { Emulator.WriteByte(_baseAddress + 0x7, value); } }
        public ushort MP { get { return Emulator.ReadUShort(_baseAddress + 0x4); } set { Emulator.WriteUShort(_baseAddress + 0x4, value); } }
        public ushort Max_MP { get { return Emulator.ReadUShort(_baseAddress + 0xA); } set { Emulator.WriteUShort(_baseAddress + 0xA, value); } }
        public ushort SP { get { return Emulator.ReadUShort(_baseAddress + 0x2); } set { Emulator.WriteUShort(_baseAddress + 0x2, value); } }
        public byte Weapon { get { return Emulator.ReadByte(_baseAddress + 0x116); } set { Emulator.WriteByte(_baseAddress + 0x116, value); } }
        public byte Helmet { get { return Emulator.ReadByte(_baseAddress + 0x118); } set { Emulator.WriteByte(_baseAddress + 0x118, value); } }
        public byte Armor { get { return Emulator.ReadByte(_baseAddress + 0x11A); } set { Emulator.WriteByte(_baseAddress + 0x11A, value); } }
        public byte Shoes { get { return Emulator.ReadByte(_baseAddress + 0x11C); } set { Emulator.WriteByte(_baseAddress + 0x11C, value); } }
        public byte Accessory { get { return Emulator.ReadByte(_baseAddress + 0x11E); } set { Emulator.WriteByte(_baseAddress + 0x11E, value); } }
        public short A_HIT { get { return Emulator.ReadShort(_baseAddress + 0x34); } set { Emulator.WriteShort(_baseAddress + 0x34, value); } }
        public short M_HIT { get { return Emulator.ReadShort(_baseAddress + 0x36); } set { Emulator.WriteShort(_baseAddress + 0x36, value); } }
        public byte On_Hit_Status { get { return Emulator.ReadByte(_baseAddress + 0x42); } set { Emulator.WriteByte(_baseAddress + 0x42, value); } }
        public byte On_Hit_Status_Chance { get { return Emulator.ReadByte(_baseAddress + 0x3C); } set { Emulator.WriteByte(_baseAddress + 0x3C, value); } }
        public ushort Add_DMG_Multi { get { return Emulator.ReadUShort(_baseAddress + 0x114); } set { Emulator.WriteUShort(_baseAddress + 0x114, value); } }
        public ushort Add_SP_Multi { get { return Emulator.ReadUShort(_baseAddress + 0x112); } set { Emulator.WriteUShort(_baseAddress + 0x112, value); } }
        public short SP_Multi { get { return Emulator.ReadShort(_baseAddress + 0x120); } set { Emulator.WriteShort(_baseAddress + 0x120, value); } }
        public short SP_P_Hit { get { return Emulator.ReadShort(_baseAddress + 0x122); } set { Emulator.WriteShort(_baseAddress + 0x122, value); } }
        public short MP_P_Hit { get { return Emulator.ReadShort(_baseAddress + 0x124); } set { Emulator.WriteShort(_baseAddress + 0x124, value); } }
        public short SP_M_Hit { get { return Emulator.ReadShort(_baseAddress + 0x126); } set { Emulator.WriteShort(_baseAddress + 0x126, value); } }
        public short MP_M_Hit { get { return Emulator.ReadShort(_baseAddress + 0x128); } set { Emulator.WriteShort(_baseAddress + 0x128, value); } }
        public short HP_Regen { get { return Emulator.ReadShort(_baseAddress + 0x12C); } set { Emulator.WriteShort(_baseAddress + 0x12C, value); } }
        public short MP_Regen { get { return Emulator.ReadShort(_baseAddress + 0x12E); } set { Emulator.WriteShort(_baseAddress + 0x12E, value); } }
        public short SP_Regen { get { return Emulator.ReadShort(_baseAddress + 0x130); } set { Emulator.WriteShort(_baseAddress + 0x130, value); } }
        public byte Revive { get { return Emulator.ReadByte(_baseAddress + 0x132); } set { Emulator.WriteByte(_baseAddress + 0x132, value); } }
        public byte Weapon_Element { get { return Emulator.ReadByte(_baseAddress + 0x14); } set { Emulator.WriteByte(_baseAddress + 0x14, value); } }
        public ushort DAT { get { return Emulator.ReadUShort(_baseAddress + 0xA4); } set { Emulator.WriteUShort(_baseAddress + 0xA4, value); } }
        public ushort DMAT { get { return Emulator.ReadUShort(_baseAddress + 0xA6); } set { Emulator.WriteUShort(_baseAddress + 0xA6, value); } }
        public ushort DDF { get { return Emulator.ReadUShort(_baseAddress + 0xA8); } set { Emulator.WriteUShort(_baseAddress + 0xA8, value); } }
        public ushort DMDF { get { return Emulator.ReadUShort(_baseAddress + 0xAA); } set { Emulator.WriteUShort(_baseAddress + 0xAA, value); } }
        public byte Image { get { return Emulator.ReadByte(_baseAddress + 0x26A); } set { Emulator.WriteByte(_baseAddress + 0x26A, value); } }
        public ushort Detransform1 { get { return Emulator.ReadUShort(_baseAddress - 0xF0); } set { Emulator.WriteUShort(_baseAddress - 0xF0, value); } }
        public byte Detransform2 { get { return Emulator.ReadByte(_baseAddress - 0xEE); } set { Emulator.WriteByte(_baseAddress - 0xEE, value); } }
        public sbyte A_HIT_Increase { get { return Emulator.ReadSByte(_baseAddress + 0xB4); } set { Emulator.WriteSByte(_baseAddress + 0xB4, value); } }
        public byte A_HIT_Increase_Turn { get { return Emulator.ReadByte(_baseAddress + 0xB5); } set { Emulator.WriteByte(_baseAddress + 0xB5, value); } }
        public sbyte M_HIT_Increase { get { return Emulator.ReadSByte(_baseAddress + 0xB6); } set { Emulator.WriteSByte(_baseAddress + 0xB6, value); } }
        public byte M_HIT_Increase_Turn { get { return Emulator.ReadByte(_baseAddress + 0xB7); } set { Emulator.WriteByte(_baseAddress + 0xB7, value); } }
        public sbyte SP_P_Hit_Increase { get { return Emulator.ReadSByte(_baseAddress + 0xC4); } set { Emulator.WriteSByte(_baseAddress + 0xC4, value); } }
        public byte SP_P_Hit_Increase_Turn { get { return Emulator.ReadByte(_baseAddress + 0xC5); } set { Emulator.WriteByte(_baseAddress + 0xC5, value); } }
        public sbyte MP_P_Hit_Increase { get { return Emulator.ReadSByte(_baseAddress + 0xC6); } set { Emulator.WriteSByte(_baseAddress + 0xC6, value); } }
        public byte MP_P_Hit_Increase_Turn { get { return Emulator.ReadByte(_baseAddress + 0xC7); } set { Emulator.WriteByte(_baseAddress + 0xC7, value); } }
        public sbyte SP_M_Hit_Increase { get { return Emulator.ReadSByte(_baseAddress + 0xC8); } set { Emulator.WriteSByte(_baseAddress + 0xC8, value); } }
        public byte SP_M_Hit_Increase_Turn { get { return Emulator.ReadByte(_baseAddress + 0xC9); } set { Emulator.WriteByte(_baseAddress + 0xC9, value); } }
        public sbyte MP_M_Hit_Increase { get { return Emulator.ReadSByte(_baseAddress + 0xCA); } set { Emulator.WriteSByte(_baseAddress + 0xCA, value); } }
        public byte MP_M_Hit_Increase_Turn { get { return Emulator.ReadByte(_baseAddress + 0xCB); } set { Emulator.WriteByte(_baseAddress + 0xCB, value); } }
        public byte ColorMap { get { return Emulator.ReadByte(_baseAddress + 0x1DD); } set { Emulator.WriteByte(_baseAddress + 0x1DD, value); } }
        public byte AdditionSlotIndex { get { return Emulator.ReadByte(_baseAddress + 0x26E); } set { Emulator.WriteByte(_baseAddress + 0x26E, value); } }
        public byte Pandemonium { get { return (byte) (Emulator.ReadByte(_pShieldMShieldSigStone + 0x1) & 3); } set { Emulator.WriteByte(_pShieldMShieldSigStone + 0x1, (byte) (Emulator.ReadByte(_pShieldMShieldSigStone + 0x1) | Math.Min(value, (byte) 3))); } }
        public byte MenuBlock { get { return Emulator.ReadByte(_menuBlock); } set { Emulator.WriteByte(_menuBlock, value); } }
        public byte DragoonTurns { get { return Emulator.ReadByte(_dragoonTurns); } set { Emulator.WriteByte(_dragoonTurns, value); } }
        public byte IsDragoon { get { return Emulator.ReadByte(_baseAddress - 0x48); } set { Emulator.WriteByte(_baseAddress - 0x48, value); } }

        internal Character(uint c_point, int slot, int position) : base(c_point, slot, position) {
            _menuBlock = 0x6E3B0 + slot * 0x20; // TODO This has to get an address
            _dragoonTurns = Emulator.GetAddress("DRAGOON_TURNS") + slot * 0x4;
        }

        public void Detransform() {
            DragoonTurns = 1;
            IsDragoon = 1;
            Detransform1 += 0x4478;
            Detransform2 = 27;
        }
    }
}