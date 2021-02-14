// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("80118AAF-5944-4591-83C1-396647F54F2C")]
    [NativeTypeName("struct IGeovisitMonitor : IInspectable")]
    public unsafe partial struct IGeovisitMonitor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, uint>)(lpVtbl[1]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, uint>)(lpVtbl[2]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, IntPtr*, int>)(lpVtbl[4]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MonitoringScope([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope *")] VisitMonitoringScope* value)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, VisitMonitoringScope*, int>)(lpVtbl[6]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Start([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitMonitoringScope")] VisitMonitoringScope value)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, VisitMonitoringScope, int>)(lpVtbl[7]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, int>)(lpVtbl[8]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int add_VisitStateChanged([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CGeolocation__CGeovisitMonitor_Windows__CDevices__CGeolocation__CGeovisitStateChangedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* handler, [NativeTypeName("EventRegistrationToken *")] EventRegistrationToken* token)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[9]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), handler, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int remove_VisitStateChanged(EventRegistrationToken token)
        {
            return ((delegate* unmanaged<IGeovisitMonitor*, EventRegistrationToken, int>)(lpVtbl[10]))((IGeovisitMonitor*)Unsafe.AsPointer(ref this), token);
        }
    }
}
