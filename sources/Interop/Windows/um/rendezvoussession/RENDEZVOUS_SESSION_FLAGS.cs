// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum RENDEZVOUS_SESSION_FLAGS
    {
        RSF_NONE = 0,
        RSF_INVITER = 0x1,
        RSF_INVITEE = 0x2,
        RSF_ORIGINAL_INVITER = 0x4,
        RSF_REMOTE_LEGACYSESSION = 0x8,
        RSF_REMOTE_WIN7SESSION = 0x10,
    }
}
