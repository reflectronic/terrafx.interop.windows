// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906C2-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1Mesh : ID2D1Resource")]
    public unsafe partial struct ID2D1Mesh
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1Mesh*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Mesh*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1Mesh*, uint>)(lpVtbl[1]))((ID2D1Mesh*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1Mesh*, uint>)(lpVtbl[2]))((ID2D1Mesh*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1Mesh*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Mesh*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open(ID2D1TessellationSink** tessellationSink)
        {
            return ((delegate* unmanaged<ID2D1Mesh*, ID2D1TessellationSink**, int>)(lpVtbl[4]))((ID2D1Mesh*)Unsafe.AsPointer(ref this), tessellationSink);
        }
    }
}
