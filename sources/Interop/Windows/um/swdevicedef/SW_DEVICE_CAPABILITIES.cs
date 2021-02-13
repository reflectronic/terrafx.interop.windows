// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/swdevicedef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum SW_DEVICE_CAPABILITIES
    {
        SWDeviceCapabilitiesNone = 0x00000000,
        SWDeviceCapabilitiesRemovable = 0x00000001,
        SWDeviceCapabilitiesSilentInstall = 0x00000002,
        SWDeviceCapabilitiesNoDisplayInUI = 0x00000004,
        SWDeviceCapabilitiesDriverRequired = 0x00000008,
    }
}
