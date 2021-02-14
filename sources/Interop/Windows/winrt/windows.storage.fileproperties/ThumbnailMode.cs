// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ThumbnailMode
    {
        ThumbnailMode_PicturesView = 0,
        ThumbnailMode_VideosView = 1,
        ThumbnailMode_MusicView = 2,
        ThumbnailMode_DocumentsView = 3,
        ThumbnailMode_ListView = 4,
        ThumbnailMode_SingleItem = 5,
    }
}
