// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum RemoteLaunchUriStatus
    {
        RemoteLaunchUriStatus_Unknown = 0,
        RemoteLaunchUriStatus_Success = 1,
        RemoteLaunchUriStatus_AppUnavailable = 2,
        RemoteLaunchUriStatus_ProtocolUnavailable = 3,
        RemoteLaunchUriStatus_RemoteSystemUnavailable = 4,
        RemoteLaunchUriStatus_ValueSetTooLarge = 5,
        RemoteLaunchUriStatus_DeniedByLocalSystem = 6,
        RemoteLaunchUriStatus_DeniedByRemoteSystem = 7,
    }
}
