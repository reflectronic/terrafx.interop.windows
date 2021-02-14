// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4DFBA589-0411-4ABC-B3B5-5BBCCB57D98C")]
    [NativeTypeName("struct IGeoboundingBoxFactory : IInspectable")]
    public unsafe partial struct IGeoboundingBoxFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, uint>)(lpVtbl[1]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, uint>)(lpVtbl[2]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, IntPtr*, int>)(lpVtbl[4]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition northwestCorner, [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition southeastCorner, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, BasicGeoposition, BasicGeoposition, IGeoboundingBox**, int>)(lpVtbl[6]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this), northwestCorner, southeastCorner, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReference([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition northwestCorner, [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition southeastCorner, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, BasicGeoposition, BasicGeoposition, AltitudeReferenceSystem, IGeoboundingBox**, int>)(lpVtbl[7]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this), northwestCorner, southeastCorner, altitudeReferenceSystem, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReferenceAndSpatialReference([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition northwestCorner, [NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition southeastCorner, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
        {
            return ((delegate* unmanaged<IGeoboundingBoxFactory*, BasicGeoposition, BasicGeoposition, AltitudeReferenceSystem, uint, IGeoboundingBox**, int>)(lpVtbl[8]))((IGeoboundingBoxFactory*)Unsafe.AsPointer(ref this), northwestCorner, southeastCorner, altitudeReferenceSystem, spatialReferenceId, value);
        }
    }
}
