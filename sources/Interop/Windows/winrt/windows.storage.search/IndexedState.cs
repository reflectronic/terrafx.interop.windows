// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IndexedState
    {
        IndexedState_Unknown = 0,
        IndexedState_NotIndexed = 1,
        IndexedState_PartiallyIndexed = 2,
        IndexedState_FullyIndexed = 3,
    }
}
