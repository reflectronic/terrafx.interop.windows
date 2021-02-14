// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FEEA0525-D22C-4D46-B527-0B96066FC7DB")]
    [NativeTypeName("struct IGeocoordinateWithPoint : IInspectable")]
    public unsafe partial struct IGeocoordinateWithPoint
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPoint*, Guid*, void**, int>)(lpVtbl[0]))((IGeocoordinateWithPoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeocoordinateWithPoint*, uint>)(lpVtbl[1]))((IGeocoordinateWithPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeocoordinateWithPoint*, uint>)(lpVtbl[2]))((IGeocoordinateWithPoint*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPoint*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocoordinateWithPoint*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPoint*, IntPtr*, int>)(lpVtbl[4]))((IGeocoordinateWithPoint*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPoint*, TrustLevel*, int>)(lpVtbl[5]))((IGeocoordinateWithPoint*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Point([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPoint*, IGeopoint**, int>)(lpVtbl[6]))((IGeocoordinateWithPoint*)Unsafe.AsPointer(ref this), value);
        }
    }
}
