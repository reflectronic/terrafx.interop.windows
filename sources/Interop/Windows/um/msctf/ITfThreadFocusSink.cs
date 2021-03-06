// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C0F1DB0C-3A20-405C-A303-96B6010A885F")]
    [NativeTypeName("struct ITfThreadFocusSink : IUnknown")]
    public unsafe partial struct ITfThreadFocusSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, uint>)(lpVtbl[1]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, uint>)(lpVtbl[2]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSetThreadFocus()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, int>)(lpVtbl[3]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnKillThreadFocus()
        {
            return ((delegate* unmanaged<ITfThreadFocusSink*, int>)(lpVtbl[4]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
        }
    }
}
