// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("032E1F8C-A9C1-4E71-8011-0DEE9D4811A3")]
    [NativeTypeName("struct IQueryOptionsFactory : IInspectable")]
    public unsafe partial struct IQueryOptionsFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, Guid*, void**, int>)(lpVtbl[0]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, uint>)(lpVtbl[1]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, uint>)(lpVtbl[2]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, IntPtr*, int>)(lpVtbl[4]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, TrustLevel*, int>)(lpVtbl[5]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommonFileQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")] IIterable<IntPtr>* fileTypeFilter, [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** queryOptions)
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, CommonFileQuery, IIterable<IntPtr>*, IQueryOptions**, int>)(lpVtbl[6]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), query, fileTypeFilter, queryOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCommonFolderQuery([NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")] CommonFolderQuery query, [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions** queryOptions)
        {
            return ((delegate* unmanaged<IQueryOptionsFactory*, CommonFolderQuery, IQueryOptions**, int>)(lpVtbl[7]))((IQueryOptionsFactory*)Unsafe.AsPointer(ref this), query, queryOptions);
        }
    }
}
