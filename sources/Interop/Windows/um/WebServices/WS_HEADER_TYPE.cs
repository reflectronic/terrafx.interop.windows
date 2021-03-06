// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WS_HEADER_TYPE
    {
        WS_ACTION_HEADER = 1,
        WS_TO_HEADER = 2,
        WS_MESSAGE_ID_HEADER = 3,
        WS_RELATES_TO_HEADER = 4,
        WS_FROM_HEADER = 5,
        WS_REPLY_TO_HEADER = 6,
        WS_FAULT_TO_HEADER = 7,
    }
}
