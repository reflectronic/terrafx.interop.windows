// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("954E4BCF-0A77-42FB-B777-C2ED58A52E44")]
    [NativeTypeName("struct IStorageFile2 : IInspectable")]
    public unsafe partial struct IStorageFile2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFile2*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFile2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFile2*, uint>)(lpVtbl[1]))((IStorageFile2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFile2*, uint>)(lpVtbl[2]))((IStorageFile2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFile2*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFile2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFile2*, IntPtr*, int>)(lpVtbl[4]))((IStorageFile2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFile2*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFile2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFile2*, FileAccessMode, StorageOpenOptions, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageFile2*)Unsafe.AsPointer(ref this), accessMode, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenTransactedWriteWithOptionsAsync([NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")] StorageOpenOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFile2*, StorageOpenOptions, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageFile2*)Unsafe.AsPointer(ref this), options, operation);
        }
    }
}
