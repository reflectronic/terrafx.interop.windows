// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("41493244-2524-4655-86A6-ED16F5FC716B")]
    [NativeTypeName("struct IGeotagHelperStatics : IInspectable")]
    public unsafe partial struct IGeotagHelperStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, uint>)(lpVtbl[1]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, uint>)(lpVtbl[2]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, IntPtr*, int>)(lpVtbl[4]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeotagAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeopoint_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, IStorageFile*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this), file, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGeotagFromGeolocatorAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeolocator *")] IGeolocator* geolocator, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, IStorageFile*, IGeolocator*, IAsyncAction**, int>)(lpVtbl[7]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this), file, geolocator, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetGeotagAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeopoint *")] IGeopoint* geopoint, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IGeotagHelperStatics*, IStorageFile*, IGeopoint*, IAsyncAction**, int>)(lpVtbl[8]))((IGeotagHelperStatics*)Unsafe.AsPointer(ref this), file, geopoint, operation);
        }
    }
}
