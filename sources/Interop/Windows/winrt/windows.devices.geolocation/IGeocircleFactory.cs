// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AFD6531F-72B1-4F7D-87CC-4ED4C9849C05")]
    [NativeTypeName("struct IGeocircleFactory : IInspectable")]
    public unsafe partial struct IGeocircleFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeocircleFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeocircleFactory*, uint>)(lpVtbl[1]))((IGeocircleFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeocircleFactory*, uint>)(lpVtbl[2]))((IGeocircleFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeocircleFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeocircleFactory*, IntPtr*, int>)(lpVtbl[4]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeocircleFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("DOUBLE")] double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value)
        {
            return ((delegate* unmanaged<IGeocircleFactory*, BasicGeoposition, double, IGeocircle**, int>)(lpVtbl[6]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), position, radius, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReferenceSystem([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("DOUBLE")] double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value)
        {
            return ((delegate* unmanaged<IGeocircleFactory*, BasicGeoposition, double, AltitudeReferenceSystem, IGeocircle**, int>)(lpVtbl[7]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), position, radius, altitudeReferenceSystem, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReferenceSystemAndSpatialReferenceId([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("DOUBLE")] double radius, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocircle **")] IGeocircle** value)
        {
            return ((delegate* unmanaged<IGeocircleFactory*, BasicGeoposition, double, AltitudeReferenceSystem, uint, IGeocircle**, int>)(lpVtbl[8]))((IGeocircleFactory*)Unsafe.AsPointer(ref this), position, radius, altitudeReferenceSystem, spatialReferenceId, value);
        }
    }
}
