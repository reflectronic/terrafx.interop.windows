// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PSS_WALK_INFORMATION_CLASS
    {
        PSS_WALK_AUXILIARY_PAGES = 0,
        PSS_WALK_VA_SPACE = 1,
        PSS_WALK_HANDLES = 2,
        PSS_WALK_THREADS = 3,
    }
}
