// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_QUALITY_LEVEL
    {
        MF_QUALITY_NORMAL = 0,
        MF_QUALITY_NORMAL_MINUS_1 = 0x1,
        MF_QUALITY_NORMAL_MINUS_2 = 0x2,
        MF_QUALITY_NORMAL_MINUS_3 = 0x3,
        MF_QUALITY_NORMAL_MINUS_4 = 0x4,
        MF_QUALITY_NORMAL_MINUS_5 = 0x5,
        MF_NUM_QUALITY_LEVELS = 0x6,
    }
}
