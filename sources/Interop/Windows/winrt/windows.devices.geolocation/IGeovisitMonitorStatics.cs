// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BCF976A7-BBF2-4CDD-95CF-554C82EDFB87")]
    [NativeTypeName("struct IGeovisitMonitorStatics : IInspectable")]
    public unsafe partial struct IGeovisitMonitorStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeovisitMonitorStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisitMonitorStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeovisitMonitorStatics*, uint>)(lpVtbl[1]))((IGeovisitMonitorStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeovisitMonitorStatics*, uint>)(lpVtbl[2]))((IGeovisitMonitorStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeovisitMonitorStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisitMonitorStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeovisitMonitorStatics*, IntPtr*, int>)(lpVtbl[4]))((IGeovisitMonitorStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeovisitMonitorStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisitMonitorStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastReportAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CGeolocation__CGeovisit_t **")] IAsyncOperation<IntPtr>** value)
        {
            return ((delegate* unmanaged<IGeovisitMonitorStatics*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IGeovisitMonitorStatics*)Unsafe.AsPointer(ref this), value);
        }
    }
}
