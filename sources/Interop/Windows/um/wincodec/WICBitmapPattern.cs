// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WICBitmapPattern
    {
        public ULARGE_INTEGER Position;

        [NativeTypeName("ULONG")]
        public uint Length;

        [NativeTypeName("BYTE *")]
        public byte* Pattern;

        [NativeTypeName("BYTE *")]
        public byte* Mask;

        [NativeTypeName("BOOL")]
        public int EndOfStream;
    }
}
