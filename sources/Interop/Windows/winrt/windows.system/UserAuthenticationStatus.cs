// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum UserAuthenticationStatus
    {
        UserAuthenticationStatus_Unauthenticated = 0,
        UserAuthenticationStatus_LocallyAuthenticated = 1,
        UserAuthenticationStatus_RemotelyAuthenticated = 2,
    }
}
