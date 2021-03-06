// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000147-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IAddrTrackingControl : IUnknown")]
    public unsafe partial struct IAddrTrackingControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAddrTrackingControl*, Guid*, void**, int>)(lpVtbl[0]))((IAddrTrackingControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAddrTrackingControl*, uint>)(lpVtbl[1]))((IAddrTrackingControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAddrTrackingControl*, uint>)(lpVtbl[2]))((IAddrTrackingControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableCOMDynamicAddrTracking()
        {
            return ((delegate* unmanaged<IAddrTrackingControl*, int>)(lpVtbl[3]))((IAddrTrackingControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DisableCOMDynamicAddrTracking()
        {
            return ((delegate* unmanaged<IAddrTrackingControl*, int>)(lpVtbl[4]))((IAddrTrackingControl*)Unsafe.AsPointer(ref this));
        }
    }
}
