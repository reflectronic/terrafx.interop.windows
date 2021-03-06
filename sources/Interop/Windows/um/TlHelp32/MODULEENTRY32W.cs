// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MODULEENTRY32W
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint th32ModuleID;

        [NativeTypeName("DWORD")]
        public uint th32ProcessID;

        [NativeTypeName("DWORD")]
        public uint GlblcntUsage;

        [NativeTypeName("DWORD")]
        public uint ProccntUsage;

        [NativeTypeName("BYTE *")]
        public byte* modBaseAddr;

        [NativeTypeName("DWORD")]
        public uint modBaseSize;

        [NativeTypeName("HMODULE")]
        public IntPtr hModule;

        [NativeTypeName("WCHAR [256]")]
        public fixed ushort szModule[256];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort szExePath[260];
    }
}
