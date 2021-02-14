// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B9D1026-15C4-44DD-B89A-47A59B7D7C4F")]
    [NativeTypeName("struct IQueryOptionsWithProviderFilter : IInspectable")]
    public unsafe partial struct IQueryOptionsWithProviderFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IQueryOptionsWithProviderFilter*, Guid*, void**, int>)(lpVtbl[0]))((IQueryOptionsWithProviderFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueryOptionsWithProviderFilter*, uint>)(lpVtbl[1]))((IQueryOptionsWithProviderFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueryOptionsWithProviderFilter*, uint>)(lpVtbl[2]))((IQueryOptionsWithProviderFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IQueryOptionsWithProviderFilter*, uint*, Guid**, int>)(lpVtbl[3]))((IQueryOptionsWithProviderFilter*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IQueryOptionsWithProviderFilter*, IntPtr*, int>)(lpVtbl[4]))((IQueryOptionsWithProviderFilter*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IQueryOptionsWithProviderFilter*, TrustLevel*, int>)(lpVtbl[5]))((IQueryOptionsWithProviderFilter*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StorageProviderIdFilter([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IQueryOptionsWithProviderFilter*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IQueryOptionsWithProviderFilter*)Unsafe.AsPointer(ref this), value);
        }
    }
}
