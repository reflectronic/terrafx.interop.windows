// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CMS_DH_KEY_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwVersion;

        [NativeTypeName("ALG_ID")]
        public uint Algid;

        [NativeTypeName("LPSTR")]
        public sbyte* pszContentEncObjId;

        [NativeTypeName("CRYPT_DATA_BLOB")]
        public CRYPTOAPI_BLOB PubInfo;

        public void* pReserved;
    }
}
