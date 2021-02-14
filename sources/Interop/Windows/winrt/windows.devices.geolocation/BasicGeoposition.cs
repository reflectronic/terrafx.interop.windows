// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct BasicGeoposition
    {
        [NativeTypeName("DOUBLE")]
        public double Latitude;

        [NativeTypeName("DOUBLE")]
        public double Longitude;

        [NativeTypeName("DOUBLE")]
        public double Altitude;
    }
}
