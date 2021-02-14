// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DiagnosticAccessStatus
    {
        DiagnosticAccessStatus_Unspecified = 0,
        DiagnosticAccessStatus_Denied = 1,
        DiagnosticAccessStatus_Limited = 2,
        DiagnosticAccessStatus_Allowed = 3,
    }
}
