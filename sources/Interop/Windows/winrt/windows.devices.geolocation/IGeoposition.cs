// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C18D0454-7D41-4FF7-A957-9DFFB4EF7F5B")]
    [NativeTypeName("struct IGeoposition : IInspectable")]
    public unsafe partial struct IGeoposition
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeoposition*, Guid*, void**, int>)(lpVtbl[0]))((IGeoposition*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeoposition*, uint>)(lpVtbl[1]))((IGeoposition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeoposition*, uint>)(lpVtbl[2]))((IGeoposition*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeoposition*, uint*, Guid**, int>)(lpVtbl[3]))((IGeoposition*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeoposition*, IntPtr*, int>)(lpVtbl[4]))((IGeoposition*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeoposition*, TrustLevel*, int>)(lpVtbl[5]))((IGeoposition*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Coordinate([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocoordinate **")] IGeocoordinate** value)
        {
            return ((delegate* unmanaged<IGeoposition*, IGeocoordinate**, int>)(lpVtbl[6]))((IGeoposition*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_CivicAddress([NativeTypeName("ABI::Windows::Devices::Geolocation::ICivicAddress **")] ICivicAddress** value)
        {
            return ((delegate* unmanaged<IGeoposition*, ICivicAddress**, int>)(lpVtbl[7]))((IGeoposition*)Unsafe.AsPointer(ref this), value);
        }
    }
}
