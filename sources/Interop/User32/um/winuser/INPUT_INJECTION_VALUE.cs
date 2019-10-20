// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct INPUT_INJECTION_VALUE
    {
        [NativeTypeName("USHORT")]
        public ushort page;

        [NativeTypeName("USHORT")]
        public ushort usage;

        [NativeTypeName("INT32")]
        public int value;

        [NativeTypeName("USHORT")]
        public ushort index;
    }
}