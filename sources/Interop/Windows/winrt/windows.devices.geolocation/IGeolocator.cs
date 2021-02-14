// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9C3BF62-4524-4989-8AA9-DE019D2E551F")]
    [NativeTypeName("struct IGeolocator : IInspectable")]
    public unsafe partial struct IGeolocator
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeolocator*, Guid*, void**, int>)(lpVtbl[0]))((IGeolocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeolocator*, uint>)(lpVtbl[1]))((IGeolocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeolocator*, uint>)(lpVtbl[2]))((IGeolocator*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeolocator*, uint*, Guid**, int>)(lpVtbl[3]))((IGeolocator*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeolocator*, IntPtr*, int>)(lpVtbl[4]))((IGeolocator*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeolocator*, TrustLevel*, int>)(lpVtbl[5]))((IGeolocator*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredAccuracy([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionAccuracy *")] PositionAccuracy* value)
        {
            return ((delegate* unmanaged<IGeolocator*, PositionAccuracy*, int>)(lpVtbl[6]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredAccuracy([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionAccuracy")] PositionAccuracy value)
        {
            return ((delegate* unmanaged<IGeolocator*, PositionAccuracy, int>)(lpVtbl[7]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MovementThreshold([NativeTypeName("DOUBLE *")] double* value)
        {
            return ((delegate* unmanaged<IGeolocator*, double*, int>)(lpVtbl[8]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_MovementThreshold([NativeTypeName("DOUBLE")] double value)
        {
            return ((delegate* unmanaged<IGeolocator*, double, int>)(lpVtbl[9]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ReportInterval([NativeTypeName("UINT32 *")] uint* value)
        {
            return ((delegate* unmanaged<IGeolocator*, uint*, int>)(lpVtbl[10]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ReportInterval([NativeTypeName("UINT32")] uint value)
        {
            return ((delegate* unmanaged<IGeolocator*, uint, int>)(lpVtbl[11]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LocationStatus([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionStatus *")] PositionStatus* value)
        {
            return ((delegate* unmanaged<IGeolocator*, PositionStatus*, int>)(lpVtbl[12]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeopositionAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** value)
        {
            return ((delegate* unmanaged<IGeolocator*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IGeolocator*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGeopositionAsyncWithAgeAndTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan maximumAge, [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan timeout, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeoposition_t **")] IAsyncOperation<IntPtr>** value)
        {
            return ((delegate* unmanaged<IGeolocator*, TimeSpan, TimeSpan, IAsyncOperation<IntPtr>**, int>)(lpVtbl[14]))((IGeolocator*)Unsafe.AsPointer(ref this), maximumAge, timeout, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_PositionChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CPositionChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGeolocator*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[15]))((IGeolocator*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_PositionChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGeolocator*, EventRegistrationToken, int>)(lpVtbl[16]))((IGeolocator*)Unsafe.AsPointer(ref this), token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_StatusChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeolocator_Windows__CDevices__CGeolocation__CStatusChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGeolocator*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[17]))((IGeolocator*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_StatusChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGeolocator*, EventRegistrationToken, int>)(lpVtbl[18]))((IGeolocator*)Unsafe.AsPointer(ref this), token);
        }
    }
}
