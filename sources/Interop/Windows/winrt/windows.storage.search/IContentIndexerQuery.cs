// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("70E3B0F8-4BFC-428A-8889-CC51DA9A7B9D")]
    [NativeTypeName("struct IContentIndexerQuery : IInspectable")]
    public unsafe partial struct IContentIndexerQuery
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, uint>)(lpVtbl[1]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, uint>)(lpVtbl[2]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, IntPtr*, int>)(lpVtbl[4]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCountAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")] IAsyncOperation<uint>** operation)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, IAsyncOperation<uint>**, int>)(lpVtbl[6]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertiesRangeAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, uint, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), startIndex, maxItems, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRangeAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItems, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CSearch__CIIndexableContent_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, uint, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), startIndex, maxItems, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_QueryFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IContentIndexerQuery*, IStorageFolder**, int>)(lpVtbl[11]))((IContentIndexerQuery*)Unsafe.AsPointer(ref this), value);
        }
    }
}
