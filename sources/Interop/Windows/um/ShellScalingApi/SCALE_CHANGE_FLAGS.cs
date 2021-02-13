// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum SCALE_CHANGE_FLAGS
    {
        SCF_VALUE_NONE = 0x00,
        SCF_SCALE = 0x01,
        SCF_PHYSICAL = 0x02,
    }
}
