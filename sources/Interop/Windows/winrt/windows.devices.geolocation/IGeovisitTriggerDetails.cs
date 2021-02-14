// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA770D9E-D1C9-454B-99B7-B2F8CDD2482F")]
    [NativeTypeName("struct IGeovisitTriggerDetails : IInspectable")]
    public unsafe partial struct IGeovisitTriggerDetails
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeovisitTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisitTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeovisitTriggerDetails*, uint>)(lpVtbl[1]))((IGeovisitTriggerDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeovisitTriggerDetails*, uint>)(lpVtbl[2]))((IGeovisitTriggerDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeovisitTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisitTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeovisitTriggerDetails*, IntPtr*, int>)(lpVtbl[4]))((IGeovisitTriggerDetails*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeovisitTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisitTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReadReports([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CGeolocation__CGeovisit_t **")] IVectorView<IntPtr>** values)
        {
            return ((delegate* unmanaged<IGeovisitTriggerDetails*, IVectorView<IntPtr>**, int>)(lpVtbl[6]))((IGeovisitTriggerDetails*)Unsafe.AsPointer(ref this), values);
        }
    }
}