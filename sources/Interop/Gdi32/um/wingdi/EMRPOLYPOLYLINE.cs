// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct EMRPOLYPOLYLINE
    {
        public EMR emr;

        public RECTL rclBounds;

        [NativeTypeName("DWORD")]
        public uint nPolys;

        [NativeTypeName("DWORD")]
        public uint cptl;

        [NativeTypeName("DWORD [1]")]
        public fixed uint aPolyCounts[1];

        [NativeTypeName("POINTL [1]")]
        public _aptl_e__FixedBuffer aptl;

        public partial struct _aptl_e__FixedBuffer
        {
            internal POINTL e0;

            public ref POINTL this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<POINTL> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}