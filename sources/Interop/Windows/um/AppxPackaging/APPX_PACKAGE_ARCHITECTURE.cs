// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum APPX_PACKAGE_ARCHITECTURE
    {
        APPX_PACKAGE_ARCHITECTURE_X86 = 0,
        APPX_PACKAGE_ARCHITECTURE_ARM = 5,
        APPX_PACKAGE_ARCHITECTURE_X64 = 9,
        APPX_PACKAGE_ARCHITECTURE_NEUTRAL = 11,
        APPX_PACKAGE_ARCHITECTURE_ARM64 = 12,
    }
}
