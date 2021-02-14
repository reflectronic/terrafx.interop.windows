// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum StorageItemTypes : uint
    {
        StorageItemTypes_None = 0,
        StorageItemTypes_File = 0x1,
        StorageItemTypes_Folder = 0x2,
    }
}
