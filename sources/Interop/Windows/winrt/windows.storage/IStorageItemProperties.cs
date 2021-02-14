// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("86664478-8029-46FE-A789-1C2F3E2FFB5C")]
    [NativeTypeName("struct IStorageItemProperties : IInspectable")]
    public unsafe partial struct IStorageItemProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, Guid*, void**, int>)(lpVtbl[0]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStorageItemProperties*, uint>)(lpVtbl[1]))((IStorageItemProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStorageItemProperties*, uint>)(lpVtbl[2]))((IStorageItemProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, IntPtr*, int>)(lpVtbl[4]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, TrustLevel*, int>)(lpVtbl[5]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnailAsyncOverloadDefaultSizeDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, ThumbnailMode, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), mode, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnailAsyncOverloadDefaultOptions([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, ThumbnailMode, uint, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), mode, requestedSize, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetThumbnailAsync([NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode, [NativeTypeName("UINT32")] uint requestedSize, [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")] ThumbnailOptions options, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, ThumbnailMode, uint, ThumbnailOptions, IAsyncOperation<IntPtr>**, int>)(lpVtbl[8]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), mode, requestedSize, options, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, IntPtr*, int>)(lpVtbl[9]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayType([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, IntPtr*, int>)(lpVtbl[10]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FolderRelativeId([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, IntPtr*, int>)(lpVtbl[11]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Properties([NativeTypeName("ABI::Windows::Storage::FileProperties::IStorageItemContentProperties **")] IStorageItemContentProperties** value)
        {
            return ((delegate* unmanaged<IStorageItemProperties*, IStorageItemContentProperties**, int>)(lpVtbl[12]))((IStorageItemProperties*)Unsafe.AsPointer(ref this), value);
        }
    }
}
