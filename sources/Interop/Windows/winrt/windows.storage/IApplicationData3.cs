// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC222CF4-2772-4C1D-AA2C-C9F743ADE8D1")]
    [NativeTypeName("struct IApplicationData3 : IInspectable")]
    public unsafe partial struct IApplicationData3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationData3*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationData3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationData3*, uint>)(lpVtbl[1]))((IApplicationData3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationData3*, uint>)(lpVtbl[2]))((IApplicationData3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IApplicationData3*, uint*, Guid**, int>)(lpVtbl[3]))((IApplicationData3*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IApplicationData3*, IntPtr*, int>)(lpVtbl[4]))((IApplicationData3*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IApplicationData3*, TrustLevel*, int>)(lpVtbl[5]))((IApplicationData3*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPublisherCacheFolder([NativeTypeName("HSTRING")] IntPtr folderName, [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IApplicationData3*, IntPtr, IStorageFolder**, int>)(lpVtbl[6]))((IApplicationData3*)Unsafe.AsPointer(ref this), folderName, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearPublisherCacheFolderAsync([NativeTypeName("HSTRING")] IntPtr folderName, [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction** clearOperation)
        {
            return ((delegate* unmanaged<IApplicationData3*, IntPtr, IAsyncAction**, int>)(lpVtbl[7]))((IApplicationData3*)Unsafe.AsPointer(ref this), folderName, clearOperation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SharedLocalFolder([NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder** value)
        {
            return ((delegate* unmanaged<IApplicationData3*, IStorageFolder**, int>)(lpVtbl[8]))((IApplicationData3*)Unsafe.AsPointer(ref this), value);
        }
    }
}
