// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("67B80708-E61A-4CD0-841B-93233792B5CA")]
    [NativeTypeName("struct IGeoboundingBoxStatics : IInspectable")]
    public unsafe partial struct IGeoboundingBoxStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, uint>)(lpVtbl[1]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, uint>)(lpVtbl[2]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, IntPtr*, int>)(lpVtbl[4]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryCompute([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, IIterable<BasicGeoposition>*, IGeoboundingBox**, int>)(lpVtbl[6]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), positions, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryComputeWithAltitudeReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeRefSystem, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, IGeoboundingBox**, int>)(lpVtbl[7]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), positions, altitudeRefSystem, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int TryComputeWithAltitudeReferenceAndSpatialReference([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IIterable<BasicGeoposition>* positions, [NativeTypeName("ABI::Windows::Devices::Geolocation::AltitudeReferenceSystem")] AltitudeReferenceSystem altitudeRefSystem, [NativeTypeName("UINT32")] uint spatialReferenceId, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoboundingBox **")] IGeoboundingBox** value)
        {
            return ((delegate* unmanaged<IGeoboundingBoxStatics*, IIterable<BasicGeoposition>*, AltitudeReferenceSystem, uint, IGeoboundingBox**, int>)(lpVtbl[8]))((IGeoboundingBoxStatics*)Unsafe.AsPointer(ref this), positions, altitudeRefSystem, spatialReferenceId, value);
        }
    }
}
