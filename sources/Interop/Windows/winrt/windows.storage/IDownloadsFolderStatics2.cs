// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E93045BD-8EF8-4F8E-8D15-AC0E265F390D")]
    [NativeTypeName("struct IDownloadsFolderStatics2 : IInspectable")]
    public unsafe partial struct IDownloadsFolderStatics2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, Guid*, void**, int>)(lpVtbl[0]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, uint>)(lpVtbl[1]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, uint>)(lpVtbl[2]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, uint*, Guid**, int>)(lpVtbl[3]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, IntPtr*, int>)(lpVtbl[4]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, TrustLevel*, int>)(lpVtbl[5]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, IUser*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderForUserAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, IUser*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileForUserWithCollisionOptionAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, IUser*, IntPtr, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, option, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFolderForUserWithCollisionOptionAsync([NativeTypeName("ABI::Windows::System::IUser *")] IUser* user, [NativeTypeName("HSTRING")] IntPtr desiredName, [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")] CreationCollisionOption option, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IDownloadsFolderStatics2*, IUser*, IntPtr, CreationCollisionOption, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IDownloadsFolderStatics2*)Unsafe.AsPointer(ref this), user, desiredName, option, operation);
        }
    }
}
