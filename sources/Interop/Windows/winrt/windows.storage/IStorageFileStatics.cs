// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5984C710-DAF2-43C8-8BB4-A4D3EACFD03F")]
    [NativeTypeName("struct IStorageFileStatics : IInspectable")]
    public unsafe partial struct IStorageFileStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, Guid*, void**, int>)(lpVtbl[0]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageFileStatics*, uint>)(lpVtbl[1]))((IStorageFileStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageFileStatics*, uint>)(lpVtbl[2]))((IStorageFileStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, IntPtr*, int>)(lpVtbl[4]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, TrustLevel*, int>)(lpVtbl[5]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileFromPathAsync([NativeTypeName("HSTRING")] IntPtr path, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), path, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileFromApplicationUriAsync([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, IUriRuntimeClass*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), uri, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStreamedFileAsync([NativeTypeName("HSTRING")] IntPtr displayNameWithExtension, [NativeTypeName("ABI::Windows::Storage::IStreamedFileDataRequestedHandler *")] IStreamedFileDataRequestedHandler* dataRequested, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, IntPtr, IStreamedFileDataRequestedHandler*, IRandomAccessStreamReference*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), displayNameWithExtension, dataRequested, thumbnail, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceWithStreamedFileAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Storage::IStreamedFileDataRequestedHandler *")] IStreamedFileDataRequestedHandler* dataRequested, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, IStorageFile*, IStreamedFileDataRequestedHandler*, IRandomAccessStreamReference*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), fileToReplace, dataRequested, thumbnail, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateStreamedFileFromUriAsync([NativeTypeName("HSTRING")] IntPtr displayNameWithExtension, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, IntPtr, IUriRuntimeClass*, IRandomAccessStreamReference*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), displayNameWithExtension, uri, thumbnail, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReplaceWithStreamedFileFromUriAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* fileToReplace, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* uri, [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")] IRandomAccessStreamReference* thumbnail, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageFileStatics*, IStorageFile*, IUriRuntimeClass*, IRandomAccessStreamReference*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IStorageFileStatics*)Unsafe.AsPointer(ref this), fileToReplace, uri, thumbnail, operation);
        }
    }
}
