// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4207A996-CA2F-42F7-BDE8-8B10457A7F30")]
    [NativeTypeName("struct IStorageItem : IInspectable")]
    public unsafe partial struct IStorageItem
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageItem*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageItem*, uint>)(lpVtbl[1]))((IStorageItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageItem*, uint>)(lpVtbl[2]))((IStorageItem*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageItem*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItem*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageItem*, IntPtr*, int>)(lpVtbl[4]))((IStorageItem*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageItem*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItem*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenameAsyncOverloadDefaultOptions([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageItem*, IntPtr, IAsyncAction**, int>)(lpVtbl[6]))((IStorageItem*)Unsafe.AsPointer(ref this), desiredName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RenameAsync([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageItem*, IntPtr, NameCollisionOption, IAsyncAction**, int>)(lpVtbl[7]))((IStorageItem*)Unsafe.AsPointer(ref this), desiredName, option, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageItem*, IAsyncAction**, int>)(lpVtbl[8]))((IStorageItem*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteAsync([NativeTypeName("ABI::Windows::Storage::StorageDeleteOption")] StorageDeleteOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageItem*, StorageDeleteOption, IAsyncAction**, int>)(lpVtbl[9]))((IStorageItem*)Unsafe.AsPointer(ref this), option, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBasicPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CBasicProperties_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItem*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IStorageItem*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Name([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageItem*, IntPtr*, int>)(lpVtbl[11]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Path([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageItem*, IntPtr*, int>)(lpVtbl[12]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Attributes([NativeTypeName("ABI::Windows::Storage::FileAttributes *")] FileAttributes* value)
        {
            return ((delegate* unmanaged<IStorageItem*, FileAttributes*, int>)(lpVtbl[13]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DateCreated([NativeTypeName("ABI::Windows::Foundation::DateTime *")] DateTime* value)
        {
            return ((delegate* unmanaged<IStorageItem*, DateTime*, int>)(lpVtbl[14]))((IStorageItem*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsOfType([NativeTypeName("ABI::Windows::Storage::StorageItemTypes")] StorageItemTypes type, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IStorageItem*, StorageItemTypes, byte*, int>)(lpVtbl[15]))((IStorageItem*)Unsafe.AsPointer(ref this), type, value);
        }
    }
}
