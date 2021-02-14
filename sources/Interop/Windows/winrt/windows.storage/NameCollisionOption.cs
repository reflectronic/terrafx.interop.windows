// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum NameCollisionOption
    {
        NameCollisionOption_GenerateUniqueName = 0,
        NameCollisionOption_ReplaceExisting = 1,
        NameCollisionOption_FailIfExists = 2,
    }
}
