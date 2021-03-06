// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CREDENTIAL_ATTRIBUTEA
    {
        [NativeTypeName("LPSTR")]
        public sbyte* Keyword;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint ValueSize;

        [NativeTypeName("LPBYTE")]
        public byte* Value;
    }
}
