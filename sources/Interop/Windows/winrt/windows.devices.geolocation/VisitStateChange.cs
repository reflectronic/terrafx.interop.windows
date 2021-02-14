// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VisitStateChange
    {
        VisitStateChange_TrackingLost = 0,
        VisitStateChange_Arrived = 1,
        VisitStateChange_Departed = 2,
        VisitStateChange_OtherMovement = 3,
    }
}
