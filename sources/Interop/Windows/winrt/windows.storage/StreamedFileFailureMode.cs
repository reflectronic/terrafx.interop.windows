// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum StreamedFileFailureMode
    {
        StreamedFileFailureMode_Failed = 0,
        StreamedFileFailureMode_CurrentlyUnavailable = 1,
        StreamedFileFailureMode_Incomplete = 2,
    }
}