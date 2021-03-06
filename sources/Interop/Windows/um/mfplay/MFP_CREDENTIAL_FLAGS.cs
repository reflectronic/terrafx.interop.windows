// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFP_CREDENTIAL_FLAGS
    {
        MFP_CREDENTIAL_PROMPT = 0x1,
        MFP_CREDENTIAL_SAVE = 0x2,
        MFP_CREDENTIAL_DO_NOT_CACHE = 0x4,
        MFP_CREDENTIAL_CLEAR_TEXT = 0x8,
        MFP_CREDENTIAL_PROXY = 0x10,
        MFP_CREDENTIAL_LOGGED_ON_USER = 0x20,
    }
}
