// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum AltitudeReferenceSystem
    {
        AltitudeReferenceSystem_Unspecified = 0,
        AltitudeReferenceSystem_Terrain = 1,
        AltitudeReferenceSystem_Ellipsoid = 2,
        AltitudeReferenceSystem_Geoid = 3,
        AltitudeReferenceSystem_Surface = 4,
    }
}
