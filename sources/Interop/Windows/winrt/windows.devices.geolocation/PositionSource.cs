// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PositionSource
    {
        PositionSource_Cellular = 0,
        PositionSource_Satellite = 1,
        PositionSource_WiFi = 2,
        PositionSource_IPAddress = 3,
        PositionSource_Unknown = 4,
        PositionSource_Default = 5,
        PositionSource_Obfuscated = 6,
    }
}
