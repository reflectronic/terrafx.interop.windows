// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27862ED0-404E-47DF-A1E2-E37308BE7B37")]
    [NativeTypeName("struct IDownloadsFolderStatics : IInspectable")]
    public unsafe partial struct IDownloadsFolderStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, Guid*, void**, int>)(lpVtbl[0]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, uint>)(lpVtbl[1]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, uint>)(lpVtbl[2]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, IntPtr*, int>)(lpVtbl[4]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, TrustLevel*, int>)(lpVtbl[5]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileAsync([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderAsync([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileWithCollisionOptionAsync([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, IntPtr, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, option, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderWithCollisionOptionAsync([NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics*, IntPtr, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IDownloadsFolderStatics*)Unsafe.AsPointer(ref this), desiredName, option, operation);
        }
    }
}
