// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8FFC224A-E782-495D-B614-654C4F0B2370")]
    [NativeTypeName("struct ICachedFileManagerStatics : IInspectable")]
    public unsafe partial struct ICachedFileManagerStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, uint>)(lpVtbl[1]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, uint>)(lpVtbl[2]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, IntPtr*, int>)(lpVtbl[4]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DeferUpdates([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file)
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, IStorageFile*, int>)(lpVtbl[6]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), file);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CompleteUpdatesAsync([NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile* file, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CProvider__CFileUpdateStatus_t **")] IAsyncOperation<int>** operation)
        {
            return ((delegate* unmanaged<ICachedFileManagerStatics*, IStorageFile*, IAsyncOperation<int>**, int>)(lpVtbl[7]))((ICachedFileManagerStatics*)Unsafe.AsPointer(ref this), file, operation);
        }
    }
}
