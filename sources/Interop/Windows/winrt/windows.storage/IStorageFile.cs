// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FA3F6186-4214-428C-A64C-14C9AC7315EA")]
    [NativeTypeName("struct IStorageFile : IInspectable")]
    public unsafe partial struct IStorageFile
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFile*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFile*, uint>)(lpVtbl[1]))((IStorageFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFile*, uint>)(lpVtbl[2]))((IStorageFile*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFile*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFile*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFile*, IntPtr*, int>)(lpVtbl[4]))((IStorageFile*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFile*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFile*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileType([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageFile*, IntPtr*, int>)(lpVtbl[6]))((IStorageFile*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ContentType([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageFile*, IntPtr*, int>)(lpVtbl[7]))((IStorageFile*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenAsync([NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, FileAccessMode, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageFile*)Unsafe.AsPointer(ref this), accessMode, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenTransactedWriteAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IStorageFile*)Unsafe.AsPointer(ref this), operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyOverloadDefaultNameAndOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFolder*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("HSTRING")] IntPtr desiredNewName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFolder*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyOverload([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("HSTRING")] IntPtr desiredNewName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFolder*, IntPtr, NameCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[12]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, option, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CopyAndReplaceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFile*, IAsyncAction**, int>)(lpVtbl[13]))((IStorageFile*)Unsafe.AsPointer(ref this), fileToReplace, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveOverloadDefaultNameAndOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFolder*, IAsyncAction**, int>)(lpVtbl[14]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("HSTRING")] IntPtr desiredNewName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFolder*, IntPtr, IAsyncAction**, int>)(lpVtbl[15]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveOverload([NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder* destinationFolder, [NativeTypeName("HSTRING")] IntPtr desiredNewName, [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFolder*, IntPtr, NameCollisionOption, IAsyncAction**, int>)(lpVtbl[16]))((IStorageFile*)Unsafe.AsPointer(ref this), destinationFolder, desiredNewName, option, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int MoveAndReplaceAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** operation)
        {
            return ((delegate* unmanaged<IStorageFile*, IStorageFile*, IAsyncAction**, int>)(lpVtbl[17]))((IStorageFile*)Unsafe.AsPointer(ref this), fileToReplace, operation);
        }
    }
}
