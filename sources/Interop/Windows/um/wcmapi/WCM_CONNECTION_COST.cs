// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum WCM_CONNECTION_COST
    {
        WCM_CONNECTION_COST_UNKNOWN = 0x0,
        WCM_CONNECTION_COST_UNRESTRICTED = 0x1,
        WCM_CONNECTION_COST_FIXED = 0x2,
        WCM_CONNECTION_COST_VARIABLE = 0x4,
        WCM_CONNECTION_COST_OVERDATALIMIT = 0x10000,
        WCM_CONNECTION_COST_CONGESTED = 0x20000,
        WCM_CONNECTION_COST_ROAMING = 0x40000,
        WCM_CONNECTION_COST_APPROACHINGDATALIMIT = 0x80000,
    }
}
