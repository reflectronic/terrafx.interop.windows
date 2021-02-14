// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.numerics.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct Matrix3x2
    {
        [NativeTypeName("FLOAT")]
        public float M11;

        [NativeTypeName("FLOAT")]
        public float M12;

        [NativeTypeName("FLOAT")]
        public float M21;

        [NativeTypeName("FLOAT")]
        public float M22;

        [NativeTypeName("FLOAT")]
        public float M31;

        [NativeTypeName("FLOAT")]
        public float M32;
    }
}
