// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB6B8D33-76BD-4E30-8AF7-A844DC37B7A0")]
    [NativeTypeName("struct IGeopointFactory : IInspectable")]
    public unsafe partial struct IGeopointFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeopointFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGeopointFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeopointFactory*, uint>)(lpVtbl[1]))((IGeopointFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeopointFactory*, uint>)(lpVtbl[2]))((IGeopointFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeopointFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGeopointFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeopointFactory*, IntPtr*, int>)(lpVtbl[4]))((IGeopointFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeopointFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGeopointFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value)
        {
            return ((delegate* unmanaged<IGeopointFactory*, BasicGeoposition, IGeopoint**, int>)(lpVtbl[6]))((IGeopointFactory*)Unsafe.AsPointer(ref this), position, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReferenceSystem([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value)
        {
            return ((delegate* unmanaged<IGeopointFactory*, BasicGeoposition, AltitudeReferenceSystem, IGeopoint**, int>)(lpVtbl[7]))((IGeopointFactory*)Unsafe.AsPointer(ref this), position, altitudeReferenceSystem, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReferenceSystemAndSpatialReferenceId([NativeTypeName("ABI::Windows::Devices::Geolocation::BasicGeoposition")] BasicGeoposition position, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint **")] IGeopoint** value)
        {
            return ((delegate* unmanaged<IGeopointFactory*, BasicGeoposition, AltitudeReferenceSystem, uint, IGeopoint**, int>)(lpVtbl[8]))((IGeopointFactory*)Unsafe.AsPointer(ref this), position, altitudeReferenceSystem, spatialReferenceId, value);
        }
    }
}
