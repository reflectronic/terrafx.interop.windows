// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A371977-ABBF-4E1D-8AA5-6385D8884799")]
    [NativeTypeName("struct IStorageLibraryContentChangedTriggerDetails : IInspectable")]
    public unsafe partial struct IStorageLibraryContentChangedTriggerDetails
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, uint>)(lpVtbl[1]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, uint>)(lpVtbl[2]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Folder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, IStorageFolder**, int>)(lpVtbl[6]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateModifiedSinceQuery([NativeTypeName("ABI::Windows::Foundation::DateTime")] DateTime lastQueryTime, [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")] IStorageItemQueryResult** result)
        {
            return ((delegate* unmanaged<IStorageLibraryContentChangedTriggerDetails*, DateTime, IStorageItemQueryResult**, int>)(lpVtbl[7]))((IStorageLibraryContentChangedTriggerDetails*)Unsafe.AsPointer(ref this), lastQueryTime, result);
        }
    }
}
