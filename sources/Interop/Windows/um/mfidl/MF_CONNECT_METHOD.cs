// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_CONNECT_METHOD
    {
        MF_CONNECT_DIRECT = 0,
        MF_CONNECT_ALLOW_CONVERTER = 0x1,
        MF_CONNECT_ALLOW_DECODER = 0x3,
        MF_CONNECT_RESOLVE_INDEPENDENT_OUTPUTTYPES = 0x4,
        MF_CONNECT_AS_OPTIONAL = 0x10000,
        MF_CONNECT_AS_OPTIONAL_BRANCH = 0x20000,
    }
}
