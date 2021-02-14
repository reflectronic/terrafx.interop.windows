// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28823E10-4786-42F1-9730-792B3566B150")]
    [NativeTypeName("struct IContentIndexerQueryOperations : IInspectable")]
    public unsafe partial struct IContentIndexerQueryOperations
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, Guid*, void**, int>)(lpVtbl[0]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, uint>)(lpVtbl[1]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, uint>)(lpVtbl[2]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, uint*, Guid**, int>)(lpVtbl[3]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, IntPtr*, int>)(lpVtbl[4]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, TrustLevel*, int>)(lpVtbl[5]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWithSortOrderAndLanguage([NativeTypeName("HSTRING")] IntPtr searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *")] IIterable<SortEntry>* sortOrder, [NativeTypeName("HSTRING")] IntPtr searchFilterLanguage, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query)
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, IntPtr, IIterable<IntPtr>*, IIterable<SortEntry>*, IntPtr, IContentIndexerQuery**, int>)(lpVtbl[6]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), searchFilter, propertiesToRetrieve, sortOrder, searchFilterLanguage, query);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQueryWithSortOrder([NativeTypeName("HSTRING")] IntPtr searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CSearch__CSortEntry_t *")] IIterable<SortEntry>* sortOrder, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query)
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, IntPtr, IIterable<IntPtr>*, IIterable<SortEntry>*, IContentIndexerQuery**, int>)(lpVtbl[7]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), searchFilter, propertiesToRetrieve, sortOrder, query);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("HSTRING")] IntPtr searchFilter, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* propertiesToRetrieve, [NativeTypeName("ABI::Windows::Storage::Search::IContentIndexerQuery **")] IContentIndexerQuery** query)
        {
            return ((delegate* unmanaged<IContentIndexerQueryOperations*, IntPtr, IIterable<IntPtr>*, IContentIndexerQuery**, int>)(lpVtbl[8]))((IContentIndexerQueryOperations*)Unsafe.AsPointer(ref this), searchFilter, propertiesToRetrieve, query);
        }
    }
}
