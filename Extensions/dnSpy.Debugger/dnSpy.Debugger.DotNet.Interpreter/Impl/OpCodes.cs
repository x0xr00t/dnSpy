﻿/*
    Copyright (C) 2014-2019 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace dnSpy.Debugger.DotNet.Interpreter.Impl {
	/// <summary>
	/// 1-byte opcode, xx
	/// </summary>
	enum OpCode : byte {
		Add				= 0x58,
		Add_Ovf			= 0xD6,
		Add_Ovf_Un		= 0xD7,
		And				= 0x5F,
		Beq				= 0x3B,
		Beq_S			= 0x2E,
		Bge				= 0x3C,
		Bge_S			= 0x2F,
		Bge_Un			= 0x41,
		Bge_Un_S		= 0x34,
		Bgt				= 0x3D,
		Bgt_S			= 0x30,
		Bgt_Un			= 0x42,
		Bgt_Un_S		= 0x35,
		Ble				= 0x3E,
		Ble_S			= 0x31,
		Ble_Un			= 0x43,
		Ble_Un_S		= 0x36,
		Blt				= 0x3F,
		Blt_S			= 0x32,
		Blt_Un			= 0x44,
		Blt_Un_S		= 0x37,
		Bne_Un			= 0x40,
		Bne_Un_S		= 0x33,
		Box				= 0x8C,
		Br				= 0x38,
		Br_S			= 0x2B,
		Break			= 0x01,
		Brfalse			= 0x39,
		Brfalse_S		= 0x2C,
		Brtrue			= 0x3A,
		Brtrue_S		= 0x2D,
		Call			= 0x28,
		Calli			= 0x29,
		Callvirt		= 0x6F,
		Castclass		= 0x74,
		Ckfinite		= 0xC3,
		Conv_I			= 0xD3,
		Conv_I1			= 0x67,
		Conv_I2			= 0x68,
		Conv_I4			= 0x69,
		Conv_I8			= 0x6A,
		Conv_Ovf_I		= 0xD4,
		Conv_Ovf_I_Un	= 0x8A,
		Conv_Ovf_I1		= 0xB3,
		Conv_Ovf_I1_Un	= 0x82,
		Conv_Ovf_I2		= 0xB5,
		Conv_Ovf_I2_Un	= 0x83,
		Conv_Ovf_I4		= 0xB7,
		Conv_Ovf_I4_Un	= 0x84,
		Conv_Ovf_I8		= 0xB9,
		Conv_Ovf_I8_Un	= 0x85,
		Conv_Ovf_U		= 0xD5,
		Conv_Ovf_U_Un	= 0x8B,
		Conv_Ovf_U1		= 0xB4,
		Conv_Ovf_U1_Un	= 0x86,
		Conv_Ovf_U2		= 0xB6,
		Conv_Ovf_U2_Un	= 0x87,
		Conv_Ovf_U4		= 0xB8,
		Conv_Ovf_U4_Un	= 0x88,
		Conv_Ovf_U8		= 0xBA,
		Conv_Ovf_U8_Un	= 0x89,
		Conv_R_Un		= 0x76,
		Conv_R4			= 0x6B,
		Conv_R8			= 0x6C,
		Conv_U			= 0xE0,
		Conv_U1			= 0xD2,
		Conv_U2			= 0xD1,
		Conv_U4			= 0x6D,
		Conv_U8			= 0x6E,
		Cpobj			= 0x70,
		Div				= 0x5B,
		Div_Un			= 0x5C,
		Dup				= 0x25,
		Endfinally		= 0xDC,
		Isinst			= 0x75,
		Jmp				= 0x27,
		Ldarg_0			= 0x02,
		Ldarg_1			= 0x03,
		Ldarg_2			= 0x04,
		Ldarg_3			= 0x05,
		Ldarg_S			= 0x0E,
		Ldarga_S		= 0x0F,
		Ldc_I4			= 0x20,
		Ldc_I4_0		= 0x16,
		Ldc_I4_1		= 0x17,
		Ldc_I4_2		= 0x18,
		Ldc_I4_3		= 0x19,
		Ldc_I4_4		= 0x1A,
		Ldc_I4_5		= 0x1B,
		Ldc_I4_6		= 0x1C,
		Ldc_I4_7		= 0x1D,
		Ldc_I4_8		= 0x1E,
		Ldc_I4_M1		= 0x15,
		Ldc_I4_S		= 0x1F,
		Ldc_I8			= 0x21,
		Ldc_R4			= 0x22,
		Ldc_R8			= 0x23,
		Ldelem			= 0xA3,
		Ldelem_I		= 0x97,
		Ldelem_I1		= 0x90,
		Ldelem_I2		= 0x92,
		Ldelem_I4		= 0x94,
		Ldelem_I8		= 0x96,
		Ldelem_R4		= 0x98,
		Ldelem_R8		= 0x99,
		Ldelem_Ref		= 0x9A,
		Ldelem_U1		= 0x91,
		Ldelem_U2		= 0x93,
		Ldelem_U4		= 0x95,
		Ldelema			= 0x8F,
		Ldfld			= 0x7B,
		Ldflda			= 0x7C,
		Ldind_I			= 0x4D,
		Ldind_I1		= 0x46,
		Ldind_I2		= 0x48,
		Ldind_I4		= 0x4A,
		Ldind_I8		= 0x4C,
		Ldind_R4		= 0x4E,
		Ldind_R8		= 0x4F,
		Ldind_Ref		= 0x50,
		Ldind_U1		= 0x47,
		Ldind_U2		= 0x49,
		Ldind_U4		= 0x4B,
		Ldlen			= 0x8E,
		Ldloc_0			= 0x06,
		Ldloc_1			= 0x07,
		Ldloc_2			= 0x08,
		Ldloc_3			= 0x09,
		Ldloc_S			= 0x11,
		Ldloca_S		= 0x12,
		Ldnull			= 0x14,
		Ldobj			= 0x71,
		Ldsfld			= 0x7E,
		Ldsflda			= 0x7F,
		Ldstr			= 0x72,
		Ldtoken			= 0xD0,
		Leave			= 0xDD,
		Leave_S			= 0xDE,
		Mkrefany		= 0xC6,
		Mul				= 0x5A,
		Mul_Ovf			= 0xD8,
		Mul_Ovf_Un		= 0xD9,
		Neg				= 0x65,
		Newarr			= 0x8D,
		Newobj			= 0x73,
		Nop				= 0x00,
		Not				= 0x66,
		Or				= 0x60,
		Pop				= 0x26,
		Prefix1			= 0xFE,
		Prefix2			= 0xFD,
		Prefix3			= 0xFC,
		Prefix4			= 0xFB,
		Prefix5			= 0xFA,
		Prefix6			= 0xF9,
		Prefix7			= 0xF8,
		Prefixref		= 0xFF,
		Refanyval		= 0xC2,
		Rem				= 0x5D,
		Rem_Un			= 0x5E,
		Ret				= 0x2A,
		Shl				= 0x62,
		Shr				= 0x63,
		Shr_Un			= 0x64,
		Starg_S			= 0x10,
		Stelem			= 0xA4,
		Stelem_I		= 0x9B,
		Stelem_I1		= 0x9C,
		Stelem_I2		= 0x9D,
		Stelem_I4		= 0x9E,
		Stelem_I8		= 0x9F,
		Stelem_R4		= 0xA0,
		Stelem_R8		= 0xA1,
		Stelem_Ref		= 0xA2,
		Stfld			= 0x7D,
		Stind_I			= 0xDF,
		Stind_I1		= 0x52,
		Stind_I2		= 0x53,
		Stind_I4		= 0x54,
		Stind_I8		= 0x55,
		Stind_R4		= 0x56,
		Stind_R8		= 0x57,
		Stind_Ref		= 0x51,
		Stloc_0			= 0x0A,
		Stloc_1			= 0x0B,
		Stloc_2			= 0x0C,
		Stloc_3			= 0x0D,
		Stloc_S			= 0x13,
		Stobj			= 0x81,
		Stsfld			= 0x80,
		Sub				= 0x59,
		Sub_Ovf			= 0xDA,
		Sub_Ovf_Un		= 0xDB,
		Switch			= 0x45,
		Throw			= 0x7A,
		Unbox			= 0x79,
		Unbox_Any		= 0xA5,
		Xor				= 0x61,
	}

	/// <summary>
	/// 2-byte opcode, FE xx
	/// </summary>
	enum OpCodeFE : byte {
		Arglist			= 0x00,
		Ceq				= 0x01,
		Cgt				= 0x02,
		Cgt_Un			= 0x03,
		Clt				= 0x04,
		Clt_Un			= 0x05,
		Constrained		= 0x16,
		Cpblk			= 0x17,
		Endfilter		= 0x11,
		Initblk			= 0x18,
		Initobj			= 0x15,
		Ldarg			= 0x09,
		Ldarga			= 0x0A,
		Ldftn			= 0x06,
		Ldloc			= 0x0C,
		Ldloca			= 0x0D,
		Ldvirtftn		= 0x07,
		Localloc		= 0x0F,
		No				= 0x19,
		Readonly		= 0x1E,
		Refanytype		= 0x1D,
		Rethrow			= 0x1A,
		Sizeof			= 0x1C,
		Starg			= 0x0B,
		Stloc			= 0x0E,
		Tailcall		= 0x14,
		Unaligned		= 0x12,
		Volatile		= 0x13,
	}
}
