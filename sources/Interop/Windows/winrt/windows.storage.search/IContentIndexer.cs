// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B1767F8D-F698-4982-B05F-3A6E8CAB01A2")]
    [NativeTypeName("struct IContentIndexer : IInspectable")]
    public unsafe partial struct IContentIndexer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IContentIndexer*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContentIndexer*, uint>)(lpVtbl[1]))((IContentIndexer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContentIndexer*, uint>)(lpVtbl[2]))((IContentIndexer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IContentIndexer*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexer*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IContentIndexer*, IntPtr*, int>)(lpVtbl[4]))((IContentIndexer*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IContentIndexer*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexer*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddAsync([NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")] IIndexableContent* indexableContent, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IContentIndexer*, IIndexableContent*, IAsyncAction**, int>)(lpVtbl[6]))((IContentIndexer*)Unsafe.AsPointer(ref this), indexableContent, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateAsync([NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")] IIndexableContent* indexableContent, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IContentIndexer*, IIndexableContent*, IAsyncAction**, int>)(lpVtbl[7]))((IContentIndexer*)Unsafe.AsPointer(ref this), indexableContent, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAsync([NativeTypeName("HSTRING")] IntPtr contentId, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IContentIndexer*, IntPtr, IAsyncAction**, int>)(lpVtbl[8]))((IContentIndexer*)Unsafe.AsPointer(ref this), contentId, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteMultipleAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* contentIds, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IContentIndexer*, IIterable<IntPtr>*, IAsyncAction**, int>)(lpVtbl[9]))((IContentIndexer*)Unsafe.AsPointer(ref this), contentIds, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAllAsync([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IContentIndexer*, IAsyncAction**, int>)(lpVtbl[10]))((IContentIndexer*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RetrievePropertiesAsync([NativeTypeName("HSTRING")] IntPtr contentId, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_IInspectable_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IContentIndexer*, IntPtr, IIterable<IntPtr>*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IContentIndexer*)Unsafe.AsPointer(ref this), contentId, propertiesToRetrieve, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Revision([NativeTypeName("UINT64 *")] ulong* value)
        {
            return ((delegate* unmanaged<IContentIndexer*, ulong*, int>)(lpVtbl[12]))((IContentIndexer*)Unsafe.AsPointer(ref this), value);
        }
    }
}
