// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CREDENTIAL_TARGET_INFORMATIONA
    {
        [NativeTypeName("LPSTR")]
        public sbyte* TargetName;

        [NativeTypeName("LPSTR")]
        public sbyte* NetbiosServerName;

        [NativeTypeName("LPSTR")]
        public sbyte* DnsServerName;

        [NativeTypeName("LPSTR")]
        public sbyte* NetbiosDomainName;

        [NativeTypeName("LPSTR")]
        public sbyte* DnsDomainName;

        [NativeTypeName("LPSTR")]
        public sbyte* DnsTreeName;

        [NativeTypeName("LPSTR")]
        public sbyte* PackageName;

        [NativeTypeName("ULONG")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint CredTypeCount;

        [NativeTypeName("LPDWORD")]
        public uint* CredTypes;
    }
}
