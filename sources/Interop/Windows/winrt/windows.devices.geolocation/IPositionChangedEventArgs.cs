// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("37859CE5-9D1E-46C5-BF3B-6AD8CAC1A093")]
    [NativeTypeName("struct IPositionChangedEventArgs : IInspectable")]
    public unsafe partial struct IPositionChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPositionChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IPositionChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPositionChangedEventArgs*, uint>)(lpVtbl[1]))((IPositionChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPositionChangedEventArgs*, uint>)(lpVtbl[2]))((IPositionChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IPositionChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IPositionChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IPositionChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IPositionChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IPositionChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IPositionChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Position([NativeTypeName("ABI::Windows::Devices::Geolocation::IGeoposition **")] IGeoposition** value)
        {
            return ((delegate* unmanaged<IPositionChangedEventArgs*, IGeoposition**, int>)(lpVtbl[6]))((IPositionChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
