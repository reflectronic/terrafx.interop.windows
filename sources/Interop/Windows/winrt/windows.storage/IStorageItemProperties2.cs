// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E86A951-04B9-4BD2-929D-FEF3F71621D0")]
    [NativeTypeName("struct IStorageItemProperties2 : IInspectable")]
    public unsafe partial struct IStorageItemProperties2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, uint>)(lpVtbl[1]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, uint>)(lpVtbl[2]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, IntPtr*, int>)(lpVtbl[4]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] int mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, int, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), mode, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScaledImageAsThumbnailAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] int mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, int, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), mode, requestedSize, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetScaledImageAsThumbnailAsync([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] int mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] uint options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItemProperties2*, int, uint, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageItemProperties2*)Unsafe.AsPointer(ref this), mode, requestedSize, options, operation);
        }
    }
}
