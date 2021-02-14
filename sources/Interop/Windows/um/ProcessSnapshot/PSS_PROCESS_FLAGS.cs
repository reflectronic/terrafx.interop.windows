// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum PSS_PROCESS_FLAGS
    {
        PSS_PROCESS_FLAGS_NONE = 0x00000000,
        PSS_PROCESS_FLAGS_PROTECTED = 0x00000001,
        PSS_PROCESS_FLAGS_WOW64 = 0x00000002,
        PSS_PROCESS_FLAGS_RESERVED_03 = 0x00000004,
        PSS_PROCESS_FLAGS_RESERVED_04 = 0x00000008,
        PSS_PROCESS_FLAGS_FROZEN = 0x00000010,
    }
}
