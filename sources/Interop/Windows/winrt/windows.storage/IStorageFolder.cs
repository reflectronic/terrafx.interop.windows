// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72D1CB78-B3EF-4F75-A80B-6FD9DAE2944B")]
    [NativeTypeName("struct IStorageFolder : IInspectable")]
    public unsafe partial struct IStorageFolder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFolder*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFolder*, uint>)(lpVtbl[1]))((IStorageFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFolder*, uint>)(lpVtbl[2]))((IStorageFolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFolder*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFolder*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr*, int>)(lpVtbl[4]))((IStorageFolder*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFolder*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFolder*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileAsyncOverloadDefaultOptions([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileAsync([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderAsyncOverloadDefaultOptions([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderAsync([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IStorageFolder*)Unsafe.AsPointer(ref this), desiredName, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileAsync([NativeTypeName("HSTRING")] IntPtr name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IStorageFolder*)Unsafe.AsPointer(ref this), name, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolderAsync([NativeTypeName("HSTRING")] IntPtr name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IStorageFolder*)Unsafe.AsPointer(ref this), name, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemAsync([NativeTypeName("HSTRING")] IntPtr name, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((IStorageFolder*)Unsafe.AsPointer(ref this), name, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFilesAsyncOverloadDefaultOptionsStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[13]))((IStorageFolder*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFoldersAsyncOverloadDefaultOptionsStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[14]))((IStorageFolder*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetItemsAsyncOverloadDefaultStartAndCount([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFolder*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[15]))((IStorageFolder*)Unsafe.AsPointer(ref this), operation);
        }
    }
}
