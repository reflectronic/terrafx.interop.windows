// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("unsigned int")]
    public enum ThumbnailOptions : uint
    {
        ThumbnailOptions_None = 0,
        ThumbnailOptions_ReturnOnlyIfCached = 0x1,
        ThumbnailOptions_ResizeThumbnail = 0x2,
        ThumbnailOptions_UseCurrentScale = 0x4,
    }
}
