// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("993011A2-FA1C-4631-A71D-0DBEB1250D9C")]
    [NativeTypeName("struct IGeolocatorStatics2 : IInspectable")]
    public unsafe partial struct IGeolocatorStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, uint>)(lpVtbl[1]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, uint>)(lpVtbl[2]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, IntPtr*, int>)(lpVtbl[4]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IsDefaultGeopositionRecommended([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, byte*, int>)(lpVtbl[6]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DefaultGeoposition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t *")] IReference<BasicGeoposition>* value)
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, IReference<BasicGeoposition>*, int>)(lpVtbl[7]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DefaultGeoposition([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CDevices__CGeolocation__CBasicGeoposition_t **")] IReference<BasicGeoposition>** value)
        {
            return ((delegate* unmanaged<IGeolocatorStatics2*, IReference<BasicGeoposition>**, int>)(lpVtbl[8]))((IGeolocatorStatics2*)Unsafe.AsPointer(ref this), value);
        }
    }
}
