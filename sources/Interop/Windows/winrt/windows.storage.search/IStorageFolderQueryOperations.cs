// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CB43CCC9-446B-4A4F-BE97-757771BE5203")]
    [NativeTypeName("struct IStorageFolderQueryOperations : IInspectable")]
    public unsafe partial struct IStorageFolderQueryOperations
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, uint>)(lpVtbl[1]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, uint>)(lpVtbl[2]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IntPtr*, int>)(lpVtbl[4]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIndexedStateAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CSearch__CIndexedState_t **")] IAsyncOperation<IndexedState>** operation)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IAsyncOperation<IndexedState>**, int>)(lpVtbl[6]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileQueryOverloadDefault([NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IStorageFileQueryResult**, int>)(lpVtbl[7]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFileQuery, IStorageFileQueryResult**, int>)(lpVtbl[8]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")] IStorageFileQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IQueryOptions*, IStorageFileQueryResult**, int>)(lpVtbl[9]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderQueryOverloadDefault([NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IStorageFolderQueryResult**, int>)(lpVtbl[10]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFolderQuery, IStorageFolderQueryResult**, int>)(lpVtbl[11]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")] IStorageFolderQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IQueryOptions*, IStorageFolderQueryResult**, int>)(lpVtbl[12]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateItemQuery([NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IStorageItemQueryResult**, int>)(lpVtbl[13]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateItemQueryWithOptions([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IQueryOptions*, IStorageItemQueryResult**, int>)(lpVtbl[14]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilesAsync([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFileQuery, uint, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[15]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, startIndex, maxItemsToRetrieve, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilesAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFileQuery, IAsyncOperation<IntPtr>**, int>)(lpVtbl[16]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFoldersAsync([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFolderQuery, uint, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[17]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, startIndex, maxItemsToRetrieve, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFoldersAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFolderQuery, IAsyncOperation<IntPtr>**, int>)(lpVtbl[18]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemsAsync([NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint maxItemsToRetrieve, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, uint, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[19]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), startIndex, maxItemsToRetrieve, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AreQueryOptionsSupported([NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")] IQueryOptions* queryOptions, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, IQueryOptions*, byte*, int>)(lpVtbl[20]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), queryOptions, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsCommonFolderQuerySupported([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFolderQuery, byte*, int>)(lpVtbl[21]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsCommonFileQuerySupported([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IStorageFolderQueryOperations*, CommonFileQuery, byte*, int>)(lpVtbl[22]))((IStorageFolderQueryOperations*)Unsafe.AsPointer(ref this), query, value);
        }
    }
}
