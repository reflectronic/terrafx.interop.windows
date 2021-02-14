// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E5E46EE-0F45-4838-A8E9-D0479D446C30")]
    [NativeTypeName("struct IQueryOptions : IInspectable")]
    public unsafe partial struct IQueryOptions
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IQueryOptions*, Guid*, void**, int>)(lpVtbl[0]))((IQueryOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueryOptions*, uint>)(lpVtbl[1]))((IQueryOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueryOptions*, uint>)(lpVtbl[2]))((IQueryOptions*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IQueryOptions*, uint*, Guid**, int>)(lpVtbl[3]))((IQueryOptions*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr*, int>)(lpVtbl[4]))((IQueryOptions*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IQueryOptions*, TrustLevel*, int>)(lpVtbl[5]))((IQueryOptions*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileTypeFilter([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")] IVector<IntPtr>** value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IVector<IntPtr>**, int>)(lpVtbl[6]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FolderDepth([NativeTypeName("ABI::Windows::Storage::Search::FolderDepth *")] FolderDepth* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, FolderDepth*, int>)(lpVtbl[7]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FolderDepth([NativeTypeName("ABI::Windows::Storage::Search::FolderDepth")] FolderDepth value)
        {
            return ((delegate* unmanaged<IQueryOptions*, FolderDepth, int>)(lpVtbl[8]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ApplicationSearchFilter([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr*, int>)(lpVtbl[9]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ApplicationSearchFilter([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr, int>)(lpVtbl[10]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UserSearchFilter([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr*, int>)(lpVtbl[11]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_UserSearchFilter([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr, int>)(lpVtbl[12]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Language([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr*, int>)(lpVtbl[13]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_Language([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr, int>)(lpVtbl[14]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_IndexerOption([NativeTypeName("ABI::Windows::Storage::Search::IndexerOption *")] IndexerOption* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IndexerOption*, int>)(lpVtbl[15]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_IndexerOption([NativeTypeName("ABI::Windows::Storage::Search::IndexerOption")] IndexerOption value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IndexerOption, int>)(lpVtbl[16]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SortOrder([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CSearch__CSortEntry_t **")] IVector<SortEntry>** value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IVector<SortEntry>**, int>)(lpVtbl[17]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_GroupPropertyName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr*, int>)(lpVtbl[18]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DateStackOption([NativeTypeName("ABI::Windows::Storage::Search::DateStackOption *")] DateStackOption* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, DateStackOption*, int>)(lpVtbl[19]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveToString([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr*, int>)(lpVtbl[20]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LoadFromString([NativeTypeName("HSTRING")] IntPtr value)
        {
            return ((delegate* unmanaged<IQueryOptions*, IntPtr, int>)(lpVtbl[21]))((IQueryOptions*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetThumbnailPrefetch([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options)
        {
            return ((delegate* unmanaged<IQueryOptions*, ThumbnailMode, uint, ThumbnailOptions, int>)(lpVtbl[22]))((IQueryOptions*)Unsafe.AsPointer(ref this), mode, requestedSize, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPropertyPrefetch([NativeTypeName("ABI::Windows::Storage::FileProperties::PropertyPrefetchOptions")] PropertyPrefetchOptions options, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* propertiesToRetrieve)
        {
            return ((delegate* unmanaged<IQueryOptions*, PropertyPrefetchOptions, IIterable<IntPtr>*, int>)(lpVtbl[23]))((IQueryOptions*)Unsafe.AsPointer(ref this), options, propertiesToRetrieve);
        }
    }
}
