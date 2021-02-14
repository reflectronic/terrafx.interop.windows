// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00980B23-2BE2-4909-AA48-159F5203A51E")]
    [NativeTypeName("struct IStorageLibraryChange : IInspectable")]
    public unsafe partial struct IStorageLibraryChange
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, Guid*, void**, int>)(lpVtbl[0]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, uint>)(lpVtbl[1]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, uint>)(lpVtbl[2]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, IntPtr*, int>)(lpVtbl[4]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, TrustLevel*, int>)(lpVtbl[5]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ChangeType([NativeTypeName("ABI::Windows::Storage::StorageLibraryChangeType *")] StorageLibraryChangeType* value)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, StorageLibraryChangeType*, int>)(lpVtbl[6]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Path([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, IntPtr*, int>)(lpVtbl[7]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_PreviousPath([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, IntPtr*, int>)(lpVtbl[8]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsOfType([NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, StorageItemTypes, byte*, int>)(lpVtbl[9]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), type, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStorageItemAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageLibraryChange*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IStorageLibraryChange*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
