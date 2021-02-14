// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A8567A1A-64F4-4D48-BCEA-F6B008ECA34C")]
    [NativeTypeName("struct ICivicAddress : IInspectable")]
    public unsafe partial struct ICivicAddress
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICivicAddress*, Guid*, void**, int>)(lpVtbl[0]))((ICivicAddress*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICivicAddress*, uint>)(lpVtbl[1]))((ICivicAddress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICivicAddress*, uint>)(lpVtbl[2]))((ICivicAddress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICivicAddress*, uint*, Guid**, int>)(lpVtbl[3]))((ICivicAddress*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICivicAddress*, IntPtr*, int>)(lpVtbl[4]))((ICivicAddress*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICivicAddress*, TrustLevel*, int>)(lpVtbl[5]))((ICivicAddress*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Country([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ICivicAddress*, IntPtr*, int>)(lpVtbl[6]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_State([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ICivicAddress*, IntPtr*, int>)(lpVtbl[7]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_City([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ICivicAddress*, IntPtr*, int>)(lpVtbl[8]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PostalCode([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<ICivicAddress*, IntPtr*, int>)(lpVtbl[9]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Timestamp([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<ICivicAddress*, DateTime*, int>)(lpVtbl[10]))((ICivicAddress*)Unsafe.AsPointer(ref this), value);
        }
    }
}
