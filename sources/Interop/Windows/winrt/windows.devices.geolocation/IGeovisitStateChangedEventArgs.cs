// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CEB4D1FF-8B53-4968-BEED-4CECD029CE15")]
    [NativeTypeName("struct IGeovisitStateChangedEventArgs : IInspectable")]
    public unsafe partial struct IGeovisitStateChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeovisitStateChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IGeovisitStateChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeovisitStateChangedEventArgs*, uint>)(lpVtbl[1]))((IGeovisitStateChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeovisitStateChangedEventArgs*, uint>)(lpVtbl[2]))((IGeovisitStateChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeovisitStateChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IGeovisitStateChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeovisitStateChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IGeovisitStateChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeovisitStateChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IGeovisitStateChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Visit([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeovisit **")] IGeovisit** value)
        {
            return ((delegate* unmanaged<IGeovisitStateChangedEventArgs*, IGeovisit**, int>)(lpVtbl[6]))((IGeovisitStateChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
