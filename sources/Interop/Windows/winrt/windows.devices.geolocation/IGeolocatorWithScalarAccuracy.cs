// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("96F5D3C1-B80F-460A-994D-A96C47A51AA4")]
    [NativeTypeName("struct IGeolocatorWithScalarAccuracy : IInspectable")]
    public unsafe partial struct IGeolocatorWithScalarAccuracy
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, Guid*, void**, int>)(lpVtbl[0]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, uint>)(lpVtbl[1]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, uint>)(lpVtbl[2]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, uint*, Guid**, int>)(lpVtbl[3]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, IntPtr*, int>)(lpVtbl[4]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, TrustLevel*, int>)(lpVtbl[5]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredAccuracyInMeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")] IReference<uint>** value)
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, IReference<uint>**, int>)(lpVtbl[6]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredAccuracyInMeters([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")] IReference<uint>* value)
        {
            return ((delegate* unmanaged<IGeolocatorWithScalarAccuracy*, IReference<uint>*, int>)(lpVtbl[7]))((IGeolocatorWithScalarAccuracy*)Unsafe.AsPointer(ref this), value);
        }
    }
}
