// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B1877A76-9EF6-41AB-A0DD-793ECE76E2DE")]
    [NativeTypeName("struct IGeovisit : IInspectable")]
    public unsafe partial struct IGeovisit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeovisit*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeovisit*, uint>)(lpVtbl[1]))((IGeovisit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeovisit*, uint>)(lpVtbl[2]))((IGeovisit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeovisit*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisit*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeovisit*, IntPtr*, int>)(lpVtbl[4]))((IGeovisit*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeovisit*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisit*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoposition **")] IGeoposition** value)
        {
            return ((delegate* unmanaged<IGeovisit*, IGeoposition**, int>)(lpVtbl[6]))((IGeovisit*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StateChange([NativeTypeName("ABI::Windows::Devices::Geolocation::VisitStateChange *")] VisitStateChange* value)
        {
            return ((delegate* unmanaged<IGeovisit*, VisitStateChange*, int>)(lpVtbl[7]))((IGeovisit*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IGeovisit*, DateTime*, int>)(lpVtbl[8]))((IGeovisit*)Unsafe.AsPointer(ref this), value);
        }
    }
}
