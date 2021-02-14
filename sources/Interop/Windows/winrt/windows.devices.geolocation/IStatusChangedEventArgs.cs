// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3453D2DA-8C93-4111-A205-9AECFC9BE5C0")]
    [NativeTypeName("struct IStatusChangedEventArgs : IInspectable")]
    public unsafe partial struct IStatusChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStatusChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IStatusChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStatusChangedEventArgs*, uint>)(lpVtbl[1]))((IStatusChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStatusChangedEventArgs*, uint>)(lpVtbl[2]))((IStatusChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStatusChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IStatusChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStatusChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IStatusChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStatusChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IStatusChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Status([NativeTypeName("ABI::Windows::Devices::Geolocation::PositionStatus *")] PositionStatus* value)
        {
            return ((delegate* unmanaged<IStatusChangedEventArgs*, PositionStatus*, int>)(lpVtbl[6]))((IStatusChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
