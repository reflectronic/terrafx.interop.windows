// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CREDENTIALA
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint Type;

        [NativeTypeName("LPSTR")]
        public sbyte* TargetName;

        [NativeTypeName("LPSTR")]
        public sbyte* Comment;

        public FILETIME LastWritten;

        [NativeTypeName("DWORD")]
        public uint CredentialBlobSize;

        [NativeTypeName("LPBYTE")]
        public byte* CredentialBlob;

        [NativeTypeName("DWORD")]
        public uint Persist;

        [NativeTypeName("DWORD")]
        public uint AttributeCount;

        [NativeTypeName("PCREDENTIAL_ATTRIBUTEA")]
        public CREDENTIAL_ATTRIBUTEA* Attributes;

        [NativeTypeName("LPSTR")]
        public sbyte* TargetAlias;

        [NativeTypeName("LPSTR")]
        public sbyte* UserName;
    }
}
