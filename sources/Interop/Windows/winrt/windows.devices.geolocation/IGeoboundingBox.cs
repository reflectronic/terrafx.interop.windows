// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0896C80B-274F-43DA-9A06-CBFCDAEB4EC2")]
    [NativeTypeName("struct IGeoboundingBox : IInspectable")]
    public unsafe partial struct IGeoboundingBox
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, Guid*, void**, int>)(lpVtbl[0]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeoboundingBox*, uint>)(lpVtbl[1]))((IGeoboundingBox*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeoboundingBox*, uint>)(lpVtbl[2]))((IGeoboundingBox*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, IntPtr*, int>)(lpVtbl[4]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, TrustLevel*, int>)(lpVtbl[5]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NorthwestCorner([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, BasicGeoposition*, int>)(lpVtbl[6]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SoutheastCorner([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, BasicGeoposition*, int>)(lpVtbl[7]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Center([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition *")] BasicGeoposition* value)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, BasicGeoposition*, int>)(lpVtbl[8]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MinAltitude([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, double*, int>)(lpVtbl[9]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MaxAltitude([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IGeoboundingBox*, double*, int>)(lpVtbl[10]))((IGeoboundingBox*)Unsafe.AsPointer(ref this), value);
        }
    }
}
