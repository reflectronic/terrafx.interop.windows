// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27BEA9C8-C7E7-4359-9B9B-FCA3E05EF593")]
    [NativeTypeName("struct IGeopathFactory : IInspectable")]
    public unsafe partial struct IGeopathFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeopathFactory*, Guid*, void**, int>)(lpVtbl[0]))((IGeopathFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeopathFactory*, uint>)(lpVtbl[1]))((IGeopathFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeopathFactory*, uint>)(lpVtbl[2]))((IGeopathFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeopathFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IGeopathFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeopathFactory*, IntPtr*, int>)(lpVtbl[4]))((IGeopathFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeopathFactory*, TrustLevel*, int>)(lpVtbl[5]))((IGeopathFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Create([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopath **")] IGeopath** value)
        {
            return ((delegate* unmanaged<IGeopathFactory*, IIterable<BasicGeoposition>*, IGeopath**, int>)(lpVtbl[6]))((IGeopathFactory*)Unsafe.AsPointer(ref this), positions, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopath **")] IGeopath** value)
        {
            return ((delegate* unmanaged<IGeopathFactory*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, IGeopath**, int>)(lpVtbl[7]))((IGeopathFactory*)Unsafe.AsPointer(ref this), positions, altitudeReferenceSystem, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithAltitudeReferenceAndSpatialReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeReferenceSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopath **")] IGeopath** value)
        {
            return ((delegate* unmanaged<IGeopathFactory*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, uint, IGeopath**, int>)(lpVtbl[8]))((IGeopathFactory*)Unsafe.AsPointer(ref this), positions, altitudeReferenceSystem, spatialReferenceId, value);
        }
    }
}
