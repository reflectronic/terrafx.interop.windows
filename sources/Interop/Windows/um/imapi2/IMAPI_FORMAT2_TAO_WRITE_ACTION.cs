// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IMAPI_FORMAT2_TAO_WRITE_ACTION
    {
        IMAPI_FORMAT2_TAO_WRITE_ACTION_UNKNOWN = 0,
        IMAPI_FORMAT2_TAO_WRITE_ACTION_PREPARING = 0x1,
        IMAPI_FORMAT2_TAO_WRITE_ACTION_WRITING = 0x2,
        IMAPI_FORMAT2_TAO_WRITE_ACTION_FINISHING = 0x3,
        IMAPI_FORMAT2_TAO_WRITE_ACTION_VERIFYING = 0x4,
    }
}
