// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D10_SHADER_VARIABLE_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        [NativeTypeName("UINT")]
        public uint StartOffset;

        [NativeTypeName("UINT")]
        public uint Size;

        [NativeTypeName("UINT")]
        public uint uFlags;

        [NativeTypeName("LPVOID")]
        public void* DefaultValue;
    }
}
