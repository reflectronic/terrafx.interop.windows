// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MANAGEMENT_REGISTRATION_INFO
    {
        [NativeTypeName("BOOL")]
        public int fDeviceRegisteredWithManagement;

        [NativeTypeName("DWORD")]
        public uint dwDeviceRegistionKind;

        [NativeTypeName("LPWSTR")]
        public ushort* pszUPN;

        [NativeTypeName("LPWSTR")]
        public ushort* pszMDMServiceUri;
    }
}
