// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum PhotoOrientation
    {
        PhotoOrientation_Unspecified = 0,
        PhotoOrientation_Normal = 1,
        PhotoOrientation_FlipHorizontal = 2,
        PhotoOrientation_Rotate180 = 3,
        PhotoOrientation_FlipVertical = 4,
        PhotoOrientation_Transpose = 5,
        PhotoOrientation_Rotate270 = 6,
        PhotoOrientation_Transverse = 7,
        PhotoOrientation_Rotate90 = 8,
    }
}
