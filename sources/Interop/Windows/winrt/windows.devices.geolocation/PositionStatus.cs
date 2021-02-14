// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PositionStatus
    {
        PositionStatus_Ready = 0,
        PositionStatus_Initializing = 1,
        PositionStatus_NoData = 2,
        PositionStatus_Disabled = 3,
        PositionStatus_NotInitialized = 4,
        PositionStatus_NotAvailable = 5,
    }
}
