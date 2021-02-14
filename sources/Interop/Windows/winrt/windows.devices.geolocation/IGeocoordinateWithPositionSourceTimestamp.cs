// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8543FC02-C9F1-4610-AFE0-8BC3A6A87036")]
    [NativeTypeName("struct IGeocoordinateWithPositionSourceTimestamp : IInspectable")]
    public unsafe partial struct IGeocoordinateWithPositionSourceTimestamp
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionSourceTimestamp*, Guid*, void**, int>)(lpVtbl[0]))((IGeocoordinateWithPositionSourceTimestamp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionSourceTimestamp*, uint>)(lpVtbl[1]))((IGeocoordinateWithPositionSourceTimestamp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionSourceTimestamp*, uint>)(lpVtbl[2]))((IGeocoordinateWithPositionSourceTimestamp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionSourceTimestamp*, uint*, Guid**, int>)(lpVtbl[3]))((IGeocoordinateWithPositionSourceTimestamp*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionSourceTimestamp*, IntPtr*, int>)(lpVtbl[4]))((IGeocoordinateWithPositionSourceTimestamp*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionSourceTimestamp*, TrustLevel*, int>)(lpVtbl[5]))((IGeocoordinateWithPositionSourceTimestamp*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PositionSourceTimestamp([NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **")] IReference<DateTime>** value)
        {
            return ((delegate* unmanaged<IGeocoordinateWithPositionSourceTimestamp*, IReference<DateTime>**, int>)(lpVtbl[6]))((IGeocoordinateWithPositionSourceTimestamp*)Unsafe.AsPointer(ref this), value);
        }
    }
}
