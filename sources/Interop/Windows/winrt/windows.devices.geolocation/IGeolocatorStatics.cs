// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9A8E7571-2DF5-4591-9F87-EB5FD894E9B7")]
    [NativeTypeName("struct IGeolocatorStatics : IInspectable")]
    public unsafe partial struct IGeolocatorStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, uint>)(lpVtbl[1]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, uint>)(lpVtbl[2]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, IntPtr*, int>)(lpVtbl[4]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestAccessAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeolocationAccessStatus_t **")] IAsyncOperation<GeolocationAccessStatus>** result)
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, IAsyncOperation<GeolocationAccessStatus>**, int>)(lpVtbl[6]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeopositionHistoryAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime startTime, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** result)
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, DateTime, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), startTime, result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeopositionHistoryWithDurationAsync([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime startTime, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan duration, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** result)
        {
            return ((delegate* unmanaged<IGeolocatorStatics*, DateTime, TimeSpan, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IGeolocatorStatics*)Unsafe.AsPointer(ref this), startTime, duration, result);
        }
    }
}
