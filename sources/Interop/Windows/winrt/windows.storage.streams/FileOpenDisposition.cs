// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum FileOpenDisposition
    {
        FileOpenDisposition_OpenExisting = 0,
        FileOpenDisposition_OpenAlways = 1,
        FileOpenDisposition_CreateNew = 2,
        FileOpenDisposition_CreateAlways = 3,
        FileOpenDisposition_TruncateExisting = 4,
    }
}