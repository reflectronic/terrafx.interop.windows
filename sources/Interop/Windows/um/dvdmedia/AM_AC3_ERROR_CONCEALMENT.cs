// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct AM_AC3_ERROR_CONCEALMENT
    {
        [NativeTypeName("BOOL")]
        public int fRepeatPreviousBlock;

        [NativeTypeName("BOOL")]
        public int fErrorInCurrentBlock;
    }
}
