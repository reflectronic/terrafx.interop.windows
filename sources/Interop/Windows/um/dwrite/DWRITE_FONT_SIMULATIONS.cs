// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum DWRITE_FONT_SIMULATIONS
    {
        DWRITE_FONT_SIMULATIONS_NONE = 0x0000,
        DWRITE_FONT_SIMULATIONS_BOLD = 0x0001,
        DWRITE_FONT_SIMULATIONS_OBLIQUE = 0x0002,
    }
}
