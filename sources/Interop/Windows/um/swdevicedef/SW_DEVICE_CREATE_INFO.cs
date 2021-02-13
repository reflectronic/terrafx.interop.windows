// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevicedef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SW_DEVICE_CREATE_INFO
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("PCWSTR")]
        public ushort* pszInstanceId;

        [NativeTypeName("PCZZWSTR")]
        public ushort* pszzHardwareIds;

        [NativeTypeName("PCZZWSTR")]
        public ushort* pszzCompatibleIds;

        [NativeTypeName("const GUID *")]
        public Guid* pContainerId;

        [NativeTypeName("ULONG")]
        public uint CapabilityFlags;

        [NativeTypeName("PCWSTR")]
        public ushort* pszDeviceDescription;

        [NativeTypeName("PCWSTR")]
        public ushort* pszDeviceLocation;

        [NativeTypeName("const SECURITY_DESCRIPTOR *")]
        public SECURITY_DESCRIPTOR* pSecurityDescriptor;
    }
}
